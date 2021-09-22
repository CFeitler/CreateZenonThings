using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateZenonThings.Parameter;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.ReactionMatrix;

namespace CreateZenonThings.Creator
{
  public class ReactionMatrixCreator : ICreate
  {
    public void Create(IProject project, Parameter.Parameter parameter)
    {
      if (!(parameter is ReactionMatrixParameter remaParameter))
        throw new ArgumentException($"Reaction Matrix Creator got wrong parameter of type: {parameter.Type}");
      var rema = project.ReactionMatrixCollection[remaParameter.Name];
      if ((rema != null || IsRemaTypeEqual(rema, remaParameter.ReMaType)))
      {
        project.ReactionMatrixCollection.Delete(rema.Name);
      }
      rema = project.ReactionMatrixCollection.Create(remaParameter.ReMaType, remaParameter.Name);
      RemoveConditions(rema);
      foreach (var remaParameterCondition in remaParameter.Conditions)
      {
        var condition = rema.CreateCondition();
        condition.ComparisonMethod = (int)remaParameterCondition.Comparison;
        condition.DelayTime = remaParameterCondition.DelaySeconds;
        condition.TreatAllValueChangesAsNewLimitViolation =
          remaParameterCondition.TreatEachChangeOfValueAsNewLimitViolation;
        if (remaParameterCondition.FunctionIdInstant != null)
        {
          condition.FunctionId = (int)remaParameterCondition.FunctionIdInstant;
          condition.SetDynamicProperty("Status", 16);
        }
        if (remaParameter.ReMaType == ReactionMatrixType.String
            && !String.IsNullOrEmpty(remaParameterCondition.Value))
        {
          throw new NotImplementedException(
            "Setting a string value to a comparison in a string REMA is not implemented!");
        }
      }

    }

    private bool IsRemaTypeEqual(IReactionMatrix rema, ReactionMatrixType type)
    {
      if (rema == null) return false;
      return rema.Type == type;
    }

    private void RemoveConditions(IReactionMatrix rema)
    {
      if (rema == null) return;
      for (int i = rema.Count - 1; i >= 0; i--)
      {
        rema.DeleteCondition(i);
      }
    }
  }
}
