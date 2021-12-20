using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CreateZenonThings.Constants;
using CreateZenonThings.Parameter;
using CreateZenonThings.Resources;
using Scada.AddIn.Contracts;

namespace CreateZenonThings.Creator
{
  public class AllocationCreator : ICreate
  {
    /// <summary>
    /// This creates an allocation by fill a XML tempate with the data from an parameter
    /// object and import to zenon editor.
    /// The reason why this approach is preferred to directly creatin allocations by
    /// zenon API functionality is the fact that by a clever mechanism in the allocation
    /// parameter variable references to sub-projects can be used.
    /// </summary>
    /// <param name="project">project where allocation is to be created</param>
    /// <param name="parameter">parameter for allocation</param>
    public void Create(IProject project, Parameter.Parameter parameter)
    {
      var allocationParameter = parameter as AllocationParameter;
      if (allocationParameter == null)
        throw new ArgumentException($"Allocation Creator got wrong parameter of type: {parameter.Type}");

      var xDocument = GetZenonCompatibleAllocationsModelXml();
      var xModel = FillAllocationsModelXml(allocationParameter, xDocument);
      var xmlFile =  XmlFileHandling.CreateTempFilePath(this.GetType().ToString(), "AllocationModel.xml");
      File.WriteAllText(xmlFile, xDocument.ToString());
      project.AllocationCollection.ImportFromXml(xmlFile);
      // Cleanup
      File.Delete(xmlFile);
    }

    /// <summary>
    /// This returns an zenon compatible xml template without any
    /// allocation definition.
    /// </summary>
    private XDocument GetZenonCompatibleAllocationsModelXml()
    {
      var template = XmlFileHandling.CreateXmlFileFromResourcesTemplate(
        this.GetType().ToString(),
        XmlResources.XML_TEMPLATE_ALLOCATION,
        "temporarytemplate.xml");
      var xmlTemplate = XDocument.Load(template);
      File.Delete(template);
      return xmlTemplate;
    }

    private XElement FillAllocationsModelXml(AllocationParameter parameter, XDocument xmlModel)
    {
      var assignModel = xmlModel.Root.Element(XmlTags.Apartment).Element(XmlTags.Allocation.Assign);
      if (assignModel != null)
      {
        assignModel.Attribute(XmlTags.Allocation.ShortName).Value = parameter.Name;
        assignModel.Element(XmlTags.Allocation.Name).Value = parameter.Name;
        assignModel.Element(XmlTags.Allocation.SourceVariable).Value = parameter.SourceVariable.VariableName;
        assignModel.Element(XmlTags.Allocation.TargetVariable).Value = parameter.TargetVariable.VariableName;
        if (parameter.TriggerVariable == null)
        {
          assignModel.Element(XmlTags.Allocation.TriggerVariable).Value = "";
        }
        else
        {
          assignModel.Element(XmlTags.Allocation.TriggerVariable).Value = parameter.TriggerVariable.VariableName;
          assignModel.Element(XmlTags.Allocation.TriggerType).Value = parameter.TriggerType.ToString();
        }


        return assignModel;
      }
      else
      {
        throw new ArgumentException("The template for Allocation is missing definitions.");
      }
    }
  }
}
