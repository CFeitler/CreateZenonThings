using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateZenonThings.Constants;
using CreateZenonThings.Parameter;
using Scada.AddIn.Contracts;
using Scada.AddIn.Contracts.Function;
using Scada.AddIn.Contracts.Historian;

namespace CreateZenonThings.Creator
{
  public class FunctionCreator : ICreate
  {
    public void Create(IProject project, Parameter.Parameter parameter)
    {
      var functionParameter = parameter as FunctionParameter;
      if (functionParameter == null)
        throw new ArgumentException($"Function Creator got wrong parameter of type: {parameter.Type}");
      switch (functionParameter.FunctionType)
      {
        case FunctionType.ScreenSwitch:
          throw new NotImplementedException(); break;
        case FunctionType.ReturnToLastScreen:
          throw new NotImplementedException(); break;
        case FunctionType.PrintAmlAndCel:
          throw new NotImplementedException(); break;
        case FunctionType.ExportAml:
          throw new NotImplementedException(); break;
        case FunctionType.PrintScreenshot:
          throw new NotImplementedException(); break;
        case FunctionType.AlarmAcknowledgeFlashing:
          throw new NotImplementedException(); break;
        case FunctionType.ExitRuntime:
          throw new NotImplementedException(); break;
        case FunctionType.WriteSetValue:
          CreateWriteSetValueFunction(project, functionParameter);
          break;
        case FunctionType.PlayAudioFile:
          throw new NotImplementedException(); break;
        case FunctionType.StartProgram:
          throw new NotImplementedException(); break;
        case FunctionType.CloseFrame:
          throw new NotImplementedException(); break;
        case FunctionType.ReadDbaseFile:
          throw new NotImplementedException(); break;
        case FunctionType.SelectScript:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteScript:
          throw new NotImplementedException(); break;
        case FunctionType.SwitchOnlinePrintingOnOff:
          throw new NotImplementedException(); break;
        case FunctionType.PrintCurrentValues:
          throw new NotImplementedException(); break;
        case FunctionType.CloseScreen:
          throw new NotImplementedException(); break;
        case FunctionType.ExportData:
          throw new NotImplementedException(); break;
        case FunctionType.StandardRecipeSingleDialog:
          throw new NotImplementedException(); break;
        case FunctionType.StandardRecipeSingleOnlineDialog:
          throw new NotImplementedException(); break;
        case FunctionType.StandardRecipeSingleDirectly:
          throw new NotImplementedException(); break;
        case FunctionType.RedundancySwitch:
          throw new NotImplementedException(); break;
        case FunctionType.AlarmMessageListActivate:
          throw new NotImplementedException(); break;
        case FunctionType.AlarmMessageListDeactivate:
          throw new NotImplementedException(); break;
        case FunctionType.ActivateDeactivateAlarm:
          throw new NotImplementedException(); break;
        case FunctionType.ActivateDeactivateFunctionsAtLimitValues:
          throw new NotImplementedException(); break;
        case FunctionType.HdAdministrationActiveInactive:
          throw new NotImplementedException(); break;
        case FunctionType.HdAdministrationActive:
          throw new NotImplementedException(); break;
        case FunctionType.HdAdministrationInactive:
          throw new NotImplementedException(); break;
        case FunctionType.ArchiveStart:
          CreateArchiveStartFunction(project, functionParameter); 
          break;
        case FunctionType.ArchiveStop:
          CreateArchiveStopFunction(project, functionParameter); 
          break;
        case FunctionType.ShowOpenArchives:
          throw new NotImplementedException(); break;
        case FunctionType.ActivateFunctionsAtLimitValues:
          throw new NotImplementedException(); break;
        case FunctionType.DeactivateFunctionsAtLimitValues:
          throw new NotImplementedException(); break;
        case FunctionType.CommandOutput:
          throw new NotImplementedException(); break;
        case FunctionType.CreateShiftChangeProtocol:
          throw new NotImplementedException(); break;
        case FunctionType.LoginWithDialog:
          throw new NotImplementedException(); break;
        case FunctionType.Logout:
          throw new NotImplementedException(); break;
        case FunctionType.ChangePassword:
          throw new NotImplementedException(); break;
        case FunctionType.StartContinuousTone:
          throw new NotImplementedException(); break;
        case FunctionType.StopContinuousTone:
          throw new NotImplementedException(); break;
        case FunctionType.ExportCel:
          throw new NotImplementedException(); break;
        case FunctionType.PrintReportGenerator:
          throw new NotImplementedException(); break;
        case FunctionType.LoginWithoutPassword:
          throw new NotImplementedException(); break;
        case FunctionType.LanguageSwitch:
          throw new NotImplementedException(); break;
        case FunctionType.ExportReportGenerator:
          throw new NotImplementedException(); break;
        case FunctionType.OnlinePrintingStartNewPage:
          throw new NotImplementedException(); break;
        case FunctionType.FileOperation:
          throw new NotImplementedException(); break;
        case FunctionType.DriverCommand:
          throw new NotImplementedException(); break;
        case FunctionType.AcknowledgeAlarms:
          throw new NotImplementedException(); break;
        case FunctionType.WindowToBackground:
          throw new NotImplementedException(); break;
        case FunctionType.WindowToForeground:
          throw new NotImplementedException(); break;
        case FunctionType.SetFocusToFrame:
          throw new NotImplementedException(); break;
        case FunctionType.TakeFocusFromFrame:
          throw new NotImplementedException(); break;
        case FunctionType.ActivateInputToElementWithFocus:
          throw new NotImplementedException(); break;
        case FunctionType.ReportGeneratorExecute:
          throw new NotImplementedException(); break;
        case FunctionType.RecipeGroupManager:
          throw new NotImplementedException(); break;
        case FunctionType.ExportArchive:
          throw new NotImplementedException(); break;
        case FunctionType.ShowOverviewWindow:
          throw new NotImplementedException(); break;
        case FunctionType.ChangeUser:
          throw new NotImplementedException(); break;
        case FunctionType.MonitorAssign:
          throw new NotImplementedException(); break;
        case FunctionType.ActivateDeactivateAlarmGroupsOrClasses:
          throw new NotImplementedException(); break;
        case FunctionType.SendMessage:
          throw new NotImplementedException(); break;
        case FunctionType.OpenVbaEditor:
          throw new NotImplementedException(); break;
        case FunctionType.ShowVbaMacroDialog:
          throw new NotImplementedException(); break;
        case FunctionType.OpenPceEditor:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteVbaMacro:
          throw new NotImplementedException(); break;
        case FunctionType.AuthorizationInNetwork:
          throw new NotImplementedException(); break;
        case FunctionType.ReloadProject:
          throw new NotImplementedException(); break;
        case FunctionType.ShowRecipientDatabase:
          throw new NotImplementedException(); break;
        case FunctionType.SaveAmlCelRingBuffer:
          throw new NotImplementedException(); break;
        case FunctionType.MoveFocus:
          throw new NotImplementedException(); break;
        case FunctionType.ScreenWithIndex:
          throw new NotImplementedException(); break;
        case FunctionType.AlarmEventgroupLoginLogoff:
          throw new NotImplementedException(); break;
        case FunctionType.WriteTimeToVariable:
          throw new NotImplementedException(); break;
        case FunctionType.ReadTimeFromVariable:
          throw new NotImplementedException(); break;
        case FunctionType.ConfirmAlarmAcknowledgement:
          throw new NotImplementedException(); break;
        case FunctionType.SendMessageActivate:
          throw new NotImplementedException(); break;
        case FunctionType.SendMessageDeactivate:
          throw new NotImplementedException(); break;
        case FunctionType.PfsExecuteUserEvent:
          throw new NotImplementedException(); break;
        case FunctionType.OpenVstaEditor:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteVstaMacro:
          throw new NotImplementedException(); break;
        case FunctionType.ShowVstaMacroDialog:
          throw new NotImplementedException(); break;
        case FunctionType.TransferDriverSimulationImageToStandby:
          throw new NotImplementedException(); break;
        case FunctionType.ActivateDeactivateProjectSimulation:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteSapFunction:
          throw new NotImplementedException(); break;
        case FunctionType.EarthFaultSearch:
          throw new NotImplementedException(); break;
        case FunctionType.GroupClassAreaEquipmentSuppressed:
          throw new NotImplementedException(); break;
        case FunctionType.SaveCurrentQueue:
          throw new NotImplementedException(); break;
        case FunctionType.ReportViewerExportPrint:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteRecipeCommandChangeMode:
          throw new NotImplementedException(); break;
        case FunctionType.CreateControlRecipe:
          throw new NotImplementedException(); break;
        case FunctionType.MoveFrameToForeground:
          throw new NotImplementedException(); break;
        case FunctionType.AnalyzerCreateReport:
          throw new NotImplementedException(); break;
        case FunctionType.DeletePathForScreenReturn:
          throw new NotImplementedException(); break;
        case FunctionType.ImportBatchRecipes:
          throw new NotImplementedException(); break;
        case FunctionType.ExportBatchRecipes:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteCommandSequencesCommandChangeMode:
          throw new NotImplementedException(); break;
        case FunctionType.ExportCommandSequences:
          throw new NotImplementedException(); break;
        case FunctionType.ImportCommandSequences:
          throw new NotImplementedException(); break;
        case FunctionType.TeachCommandSequence:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteParallelCommands:
          throw new NotImplementedException(); break;
        case FunctionType.ProcessRecorderPlaybackMode:
          throw new NotImplementedException(); break;
        case FunctionType.ShiftManagementSqlExport:
          throw new NotImplementedException(); break;
        case FunctionType.ExecuteAddInWizard:
          throw new NotImplementedException(); break;
        case FunctionType.ManageAddInRuntimeServices:
          throw new NotImplementedException(); break;
        case FunctionType.ShowLicenseInformation:
          throw new NotImplementedException(); break;
        case FunctionType.BatchMasterRecipeRelease:
          throw new NotImplementedException(); break;
        case FunctionType.ExportContextList:
          throw new NotImplementedException(); break;
        case FunctionType.StartStopRuntimeService:
          throw new NotImplementedException(); break;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private void CreateWriteSetValueFunction(IProject project, FunctionParameter parameter)
    {
      var writeSetParameter = parameter as WriteSetValueFunctionParameter;
      if (writeSetParameter == null) throw new ArgumentException($"Function Creator got wrong parameter of type: {parameter.FunctionType}");
      var function = project.FunctionCollection[writeSetParameter.Name] 
                     ?? project.FunctionCollection.Create(writeSetParameter.Name, writeSetParameter.FunctionType);
      function.SetDynamicProperty(DynamicProperties.SetValueNumValue,writeSetParameter.TargetValue);
      function.SetDynamicProperty(DynamicProperties.SetValueMaximum,writeSetParameter.TargetValue);
      if (writeSetParameter.IsDirect)
      {
        function.SetDynamicProperty(DynamicProperties.SetValueIsDirect, true);
      }

      function.SetDynamicProperty(DynamicProperties.SetValueVariable, writeSetParameter.TargetVariable);
    }

    private void CreateArchiveStartFunction(IProject project, FunctionParameter parameter)
    {
      if (!(parameter is StartArchiveParameter startArchiveParameter)) throw new ArgumentException($"Function Creator got wrong parameter of type: {parameter.FunctionType}");
      var function = project.FunctionCollection[startArchiveParameter.Name] 
                     ?? project.FunctionCollection.Create(startArchiveParameter.Name, startArchiveParameter.FunctionType);
      function.SetDynamicProperty(DynamicProperties.ArchiveName, startArchiveParameter.ArchiveId);
    }

    private void CreateArchiveStopFunction(IProject project, FunctionParameter parameter)
    {
      if (!(parameter is StopArchiveParameter stopArchiveParameter)) throw new ArgumentException($"Function Creator got wrong parameter of type: {parameter.FunctionType}");
      var function = project.FunctionCollection[stopArchiveParameter.Name] 
                     ?? project.FunctionCollection.Create(stopArchiveParameter.Name, stopArchiveParameter.FunctionType);
      function.SetDynamicProperty(DynamicProperties.ArchiveName, stopArchiveParameter.ArchiveId);
    }
  }
}
