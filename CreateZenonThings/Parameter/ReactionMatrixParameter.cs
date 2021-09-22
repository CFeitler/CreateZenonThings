using System.Collections.Generic;
using Scada.AddIn.Contracts.ReactionMatrix;

namespace CreateZenonThings.Parameter
{
  public class ReactionMatrixParameter : Parameter
  {
    public ReactionMatrixParameter()
    {
      Type = ParameterType.ReactionMatrix;
    }

    public ReactionMatrixType ReMaType { get; set; } = ReactionMatrixType.Binary;
    public string Name { get; set; } = "";

    public List<Condition> Conditions { get; set; } = new List<Condition>();
     
    public class Condition
    {
      public ValueComparison Comparison { get; set; } = ValueComparison.any;
      public string Value { get; set; } = "";
      public int? FunctionIdInstant { get; set; }
      public int DelaySeconds { get; set; } = 0;
      public bool TreatEachChangeOfValueAsNewLimitViolation { get; set; } = false;
      public enum ValueComparison
      {
        any = 0,
        greater = 1,
        less = 2,
        equal = 3
      }
      
    }
  }
}
