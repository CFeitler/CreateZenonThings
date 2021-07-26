using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateZenonThings.Parameter
{
  public abstract class Parameter
  {
    public ParameterType Type { get; set; }
  }

  public enum ParameterType
  {
    undefined = 0,
    ReactionMatrix,
    Function,
  }
}
