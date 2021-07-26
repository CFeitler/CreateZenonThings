using Scada.AddIn.Contracts.Function;

namespace CreateZenonThings.Parameter
{
  public class FunctionParameter : Parameter
  {
    public string Name { get; set; }
    public FunctionType FunctionType { get; set; }

    public FunctionParameter()
    {
      Type = ParameterType.Function;
    }
  }

  public class WriteSetValueFunctionParameter : FunctionParameter
  {
    public WriteSetValueFunctionParameter()
    {
      FunctionType = FunctionType.WriteSetValue;
    }

    public int TargetValue { get; set; }
    public string TargetVariable { get; set; }
    public bool IsDirect { get; set; }
  }

  public class StartArchiveParameter : FunctionParameter
  {
    public StartArchiveParameter()
    {
      FunctionType = FunctionType.ArchiveStart;
    }

    public string ArchiveId { get; set; }

  }

  public class StopArchiveParameter : FunctionParameter
  {
    public StopArchiveParameter()
    {
      FunctionType = FunctionType.ArchiveStop;
    }

    public string ArchiveId { get; set; }
  }



}
