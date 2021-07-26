using System;
using System.Collections.Generic;
using System.ComponentModel;
using CreateZenonThings.Creator;
using CreateZenonThings.Parameter;
using Scada.AddIn.Contracts;

namespace CreateZenonThings
{
    public class BasicCreator 
    {
      public void Create(IProject project, Parameter.Parameter parameter)
      {
        switch (parameter.Type)
        {
          case ParameterType.undefined:
            throw new InvalidEnumArgumentException("Function Type unknown!");
            break;
          case ParameterType.ReactionMatrix:
            throw new NotImplementedException("ReMa Creator not implemented yet!");
            break;
          case ParameterType.Function:
            new FunctionCreator().Create(project,parameter);
            break;
          case ParameterType.Script:
            new ScriptCreator().Create(project, parameter);
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
      }

      public void Create(IProject project, IEnumerable<Parameter.Parameter> parameters)
      {
        foreach (var parameter in parameters)
        {
          Create(project,parameter);
        }
      }
    }
}
