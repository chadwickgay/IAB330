using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.IO;
using WheresMyStuff.Interfaces;

namespace WheresMyStuff.iOS.Interfaces
{
    public class FileHelperiOS : IFileHelper
    {
		public string GetLocalPath(string filename)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}

			return Path.Combine(libFolder, filename);
		}


    }
}
