using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuSkinningTools
{
    class SkinFiles
    {
        private static string[] ImageFormat { get; } = new string[] { "Png", "Jpg" };
        public List<string> AllImages { get; }
        public List<string> HdImages { get; }
        public List<string> SdImages { get; }

        public SkinFiles(Configuration config)
        {
            AllImages = new List<string>();

            foreach (var filter in ImageFormat)
            {
                AllImages.AddRange(Directory.GetFiles(config.WorkingDirectory, string.Format("*.{0}", filter), SearchOption.TopDirectoryOnly));
            }

            HdImages = new List<string>();
            SdImages = new List<string>();
            foreach (var current in AllImages)
            {
                //Checks if it's an HD file
                if (current.Contains(config.HighResPattern))
                {
                    HdImages.Add(current);
                }
                else
                {
                    SdImages.Add(current);
                }
            }
        }
    }
}
