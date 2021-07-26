using System;
using CreateZenonThings.Constants;
using CreateZenonThings.Parameter;
using Scada.AddIn.Contracts;

namespace CreateZenonThings.Creator
{
  public class ScriptCreator : ICreate
  {
    public void Create(IProject project, Parameter.Parameter parameter)
    {
      if (!(parameter is ScriptParameter scriptParameter))
        throw new ArgumentException($"Script Creator got wrong parameter of type: {parameter.Type}");
      var script = project.ScriptCollection[scriptParameter.Name]
                   ?? project.ScriptCollection.Create(scriptParameter.Name);
      script.SetDynamicProperty(DynamicProperties.Functions, string.Join(";", scriptParameter.FunctionNames.ToArray()));
    }
  }
}
