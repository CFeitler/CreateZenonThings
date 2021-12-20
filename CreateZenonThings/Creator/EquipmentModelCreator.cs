using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using CreateZenonThings.Constants;
using CreateZenonThings.Parameter;
using CreateZenonThings.Resources;
using Scada.AddIn.Contracts;

namespace CreateZenonThings.Creator
{
  class EquipmentModelCreator : ICreate
  {
    public void Create(IProject project, Parameter.Parameter parameter)
    {
      var equipmentModelParameter = parameter as EquipmentModelParameter;
      if (equipmentModelParameter == null)
        throw new ArgumentException($"Equipment Model Creator got wrong parameter of type: {parameter.Type}");

      var xmlEquipmentModel = GetTemplateEquipmentModel();
      xmlEquipmentModel.Element(XmlTags.EquipmentModel.Name).Value = equipmentModelParameter.Name;
      xmlEquipmentModel.Element(XmlTags.EquipmentModel.Guid).Value = equipmentModelParameter.InternalGuid;

      // setting all first level groups in equipment model
      SetEquipmentGroups(ref xmlEquipmentModel, equipmentModelParameter);

      // iterating through first level groups and setting child groups recursively
      foreach (var group in equipmentModelParameter.EquipmentGroups)
      {
        SetEquipmentSubGroups(ref xmlEquipmentModel, group.InternalGuid, group.EquipmentGroups);
      }

      // Creating the Equipment Model in a zenon compatible format and import
      var xmlTemplate = GetZenonCompatibleEquipmentModelXml();
      xmlTemplate.Root.Element(XmlTags.Apartment)
        .Add(new XElement(XmlTags.EquipmentModel.SystemModel, xmlEquipmentModel));
      var xmlFile =  XmlFileHandling.CreateTempFilePath(this.GetType().ToString(), "EquipmentModel.xml");
      File.WriteAllText(xmlFile, xmlTemplate.ToString());
      project.EquipmentModeling.ImportFromXml(xmlFile);

      // Cleanup
      File.Delete(xmlFile);
    }

    /// <summary>
    /// This gets an equipment group from template
    /// </summary>
    /// <returns>The XElement for an equipment group</returns>
    private XElement GetTemplateEquipmentGroup()
    {
      var xmlModel = GetTemplateModelNode();
      return xmlModel.Element(XmlTags.EquipmentModel.Groups).Element(XmlTags.EquipmentModel.Group);
    }

    /// <summary>
    /// This gets the equipment model from template (without any groups)
    /// </summary>
    /// <returns>The XElement for an equipment model</returns>
    private XElement GetTemplateEquipmentModel()
    {
      var xmlModel = GetTemplateModelNode();

      //remove all groups from template
      var groups = xmlModel.Elements().Where(x => x.Element(XmlTags.EquipmentModel.Group) != null).ToList();
      foreach (var group in groups)
      {
        group.Remove();
      }
      return xmlModel;
    }

    private XElement GetTemplateModelNode()
    {
      var template = XmlFileHandling.CreateXmlFileFromResourcesTemplate(
        this.GetType().ToString(), 
        XmlResources.XML_TEMPLATE_EQUIPMENT_MODEL ,
        "temporary.xml");
      var xmlTemplate = XDocument.Load(template);
      File.Delete(template);
      return xmlTemplate.Root
        .Element(XmlTags.Apartment)
        .Element(XmlTags.EquipmentModel.SystemModel)
        .Element(XmlTags.EquipmentModel.Model);
    }

    /// <summary>
    /// This returns an zenon compatible xml template without any
    /// equipment model definition.
    /// </summary>
    private XDocument GetZenonCompatibleEquipmentModelXml()
    {
      var template = XmlFileHandling.CreateXmlFileFromResourcesTemplate(
        this.GetType().ToString(),
        XmlResources.XML_TEMPLATE_EQUIPMENT_MODEL,
        "temporarytemplate.xml");
      var xmlTemplate = XDocument.Load(template);
      File.Delete(template);
      var systemModel = xmlTemplate.Root.Element(XmlTags.Apartment).Element(XmlTags.EquipmentModel.SystemModel);
      systemModel.Remove();
      return xmlTemplate;
    }

    /// <summary>
    /// Iterates through all defined first level groups and adds them to the equipment model
    /// </summary>
    private void SetEquipmentGroups(ref XElement xmlModel, EquipmentModelParameter equipmentStructure)
    {
      //get Group from template
      var equipmentGroup = GetTemplateEquipmentGroup();

      //add all equipment groups
      foreach (var group in equipmentStructure.EquipmentGroups)
      {
        equipmentGroup.Element(XmlTags.EquipmentModel.Name).Value = group.Name;
        equipmentGroup.Element(XmlTags.EquipmentModel.Guid).Value = group.InternalGuid;
        if (xmlModel.Element(XmlTags.EquipmentModel.Groups) == null)
        {
          xmlModel.Add(new XElement(XmlTags.EquipmentModel.Groups, equipmentGroup));
        }
        else
        {
          xmlModel.Element(XmlTags.EquipmentModel.Groups).Add(equipmentGroup);
        }
      }
    }

    /// <summary>
    /// Iterates through all the first level groups and sets the child groups recurively
    /// </summary>
    private void SetEquipmentSubGroups(ref XElement xmlModel, string groupId, List<EquipmentGroup> subGroups)
    {
      var xmlGroups = xmlModel.Descendants(XmlTags.EquipmentModel.Group);
      var xmlGroup = xmlGroups.Elements(XmlTags.EquipmentModel.Guid).FirstOrDefault(v => v.Value.Equals(groupId)).Parent;
      foreach (var subGroup in subGroups)
      {
        var equipmentGroup = GetTemplateEquipmentGroup();
        equipmentGroup.Element(XmlTags.EquipmentModel.Name).Value = subGroup.Name;
        equipmentGroup.Element(XmlTags.EquipmentModel.Guid).Value = subGroup.InternalGuid;
        if (xmlGroup.Element(XmlTags.EquipmentModel.ChildGroups) == null)
        {
          xmlGroup.Add(new XElement(XmlTags.EquipmentModel.ChildGroups, equipmentGroup));
        }
        else
        {
          xmlGroup.Element(XmlTags.EquipmentModel.ChildGroups).Add(equipmentGroup);
        }
        if (subGroup.EquipmentGroups != null && subGroup.EquipmentGroups.Count > 0)
        {
          SetEquipmentSubGroups(ref xmlModel, subGroup.InternalGuid, subGroup.EquipmentGroups);
        }
      }
    }
  }
}
