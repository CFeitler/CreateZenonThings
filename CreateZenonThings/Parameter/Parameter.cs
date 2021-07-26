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
    Script
  }
}
