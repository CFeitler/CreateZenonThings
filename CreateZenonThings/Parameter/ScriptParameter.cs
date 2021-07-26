using System.Collections.Generic;

namespace CreateZenonThings.Parameter
{
  public class ScriptParameter : Parameter
  {
    public ScriptParameter()
    {
      Type = ParameterType.Script;
    }

    public string Name { get; set; }
    public List<string> FunctionNames { get; set; }
  }
}
