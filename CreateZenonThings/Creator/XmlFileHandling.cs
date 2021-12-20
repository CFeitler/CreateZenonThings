using System.IO;
using CreateZenonThings.Resources;

namespace CreateZenonThings.Creator
{
  public static class XmlFileHandling
  {
    public static string CreateTempFilePath(string typeName, string fileName)
    {
      var tempDirectory = Path.Combine(Path.GetTempPath(), typeName);
      var tempXmlFile = Path.Combine(Path.GetTempPath(), typeName, fileName);
      if (!Directory.Exists(tempDirectory))
      {
        Directory.CreateDirectory(tempDirectory);
      }
      return tempXmlFile;
    }

    /// <summary>
    /// This creates an xml file from the template in resources
    /// </summary>
    /// <returns>The filepath of the temporary file</returns>
    public static string CreateXmlFileFromResourcesTemplate(string typeName, string xmlSources, string filename)
    {
      var tempXmlFile =  CreateTempFilePath(typeName, filename);
      var template = xmlSources.Replace("\0", string.Empty);
      File.WriteAllText(tempXmlFile, template);
      return tempXmlFile;
    }
  }
}
