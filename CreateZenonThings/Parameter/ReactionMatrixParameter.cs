using System.Collections.Generic;

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

    public enum ReactionMatrixType
    {
      undefined = 0,
      Binary,
      MultiBinary,
      Numeric,
      MultiNumeric,
      String
    }

    public class Condition
    {
      public ValueComparison Comparison { get; set; } = ValueComparison.any;
      public string Value { get; set; } = "";
      public enum ValueComparison
      {
        any = 0,
        greater,
        less,
        equal
      }
    }
  }
}
