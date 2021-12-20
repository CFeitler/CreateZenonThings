using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CreateZenonThings.Parameter
{
  public class AllocationParameter : Parameter
  {
    public string Name { get; set; }
    public VariableReference SourceVariable { get; set; }
    public VariableReference TargetVariable { get; set; }
    public VariableReference TriggerVariable { get; set; } = null;
    public TriggerType TriggerType { get; set; } = TriggerType.Edge;

    public AllocationParameter(string name)
    {
      Type = ParameterType.Allocation;
      Name = name;
    }
  }

  public class VariableReference
  {
    private string _variableName;
    
    public string VariableName
    {
      get
      {
        if (!IsInActiveProject)
        {
          return SubProjectName + "#" + _variableName;
        }
        else
        {
          return _variableName;
        }
      }
      set => _variableName = value;
    }

    public VariableReference(string name)
    {
      VariableName = name;
    }

    public bool IsInActiveProject { get; private set; } = true;

    private string _subProjectName;
    public string SubProjectName
    {
      get => _subProjectName;
      set
      {
        IsInActiveProject = String.IsNullOrEmpty(value);
        _subProjectName = value;
      }
    }
  }

  public enum TriggerType
  {
    Edge = 0,
    Gage = 1
  }
}
