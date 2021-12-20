using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateZenonThings.Constants
{
  public static class XmlTags
  {
    public const string Apartment = "Apartment";

    public static class EquipmentModel
    {
      public const string SystemModel = "SystemModel";
      public const string Model = "Model";
      public const string Groups = "Groups";
      public const string Group = "Group";
      public const string ChildGroups = "ChildGroups";
      public const string Name = "Name";
      public const string Guid = "GUID";
    }

    public static class Allocation
    {
      public const string Assign = "Assign";
      public const string ShortName = "ShortName";
      public const string Name = "Name";
      public const string SourceVariable = "SourceVariable";
      public const string TargetVariable = "TargetVariable";
      public const string TriggerVariable = "TriggerVariable";
      public const string TriggerType= "TriggerType";

    }
  }
}
