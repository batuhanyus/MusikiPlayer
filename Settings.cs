using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusikiPlayer
{    public static class Settings
    {
        public static string libraryLocation;
        public static string utilitiesLocation;

        public static void Run(Logic logic)
        {
            libraryLocation = AppDomain.CurrentDomain.BaseDirectory + "Library";
            utilitiesLocation = AppDomain.CurrentDomain.BaseDirectory + "Utilities";

            FoldersCheck();
        }

        static void FoldersCheck()
        {
            System.IO.Directory.CreateDirectory(libraryLocation);
            System.IO.Directory.CreateDirectory(utilitiesLocation);

        }
    }
}
