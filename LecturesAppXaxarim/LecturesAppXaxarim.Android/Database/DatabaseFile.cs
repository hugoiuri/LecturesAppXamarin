using System.IO;
using Xamarin.Forms;
using LecturesAppXamarin.Domain.Interfaces;
using LecturesAppXaxarim.Droid.Database;

[assembly: Dependency(typeof(DatabaseFile))]
namespace LecturesAppXaxarim.Droid.Database
{
    public class DatabaseFile : IDatabaseFile
    {
        public string GetFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}