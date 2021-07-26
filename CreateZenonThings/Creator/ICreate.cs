using Scada.AddIn.Contracts;

namespace CreateZenonThings.Creator
{
  public interface ICreate
  {
    /// <summary>
    /// Method creates a zenon object in a given project. the zenon object is described in parameter
    /// </summary>
    /// <param name="parameter">parameters of the zenon object.</param>
    /// <param name="project">project where the zenon things are created.</param>
    void Create(IProject project, Parameter.Parameter parameter);
  }
}
