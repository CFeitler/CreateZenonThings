using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CreateZenonThings.Parameter
{
  public class EquipmentModelParameter : Parameter
  {
    public EquipmentModelParameter(string name)
    {
      Name = name;
      Type = ParameterType.EquipentModel;
      InternalGuid = Guid.NewGuid().ToString();
      EquipmentGroups = new List<EquipmentGroup>();
    }

    public string Name { get; set; }
    public string InternalGuid { get; set; }
    public List<EquipmentGroup> EquipmentGroups { get; set; }
  }

  public class EquipmentGroup
  {
    public string Name { get; set; }
    public string InternalGuid { get; set; }
    public List<EquipmentGroup> EquipmentGroups { get; set; }

    public EquipmentGroup(string name)
    {
      Name = name;
      InternalGuid = Guid.NewGuid().ToString();
      EquipmentGroups = new List<EquipmentGroup>();
    }

    public EquipmentGroup(string name, params EquipmentGroup[] equipmentGroup) :this(name)
    {
      EquipmentGroups.AddRange(equipmentGroup.ToList());
    }
  }
}
