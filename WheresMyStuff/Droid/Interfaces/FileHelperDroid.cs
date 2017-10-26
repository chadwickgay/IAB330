using System;
using System.IO;
using WheresMyStuff.Interfaces;

namespace WheresMyStuff.Droid.Interfaces
{
    public class FileHelperDroid : IFileHelper
    {
        public string GetLocalPath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            return Path.Combine(path, filename);
        }
    }
}
