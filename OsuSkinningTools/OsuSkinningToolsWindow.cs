using ConfigHelper;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuSkinningTools
{
    public partial class OsuSkinningToolsWindow : Form
    {
        private ConfigurationHelper<Configuration> ConfigHelper { get; }
        private Configuration Config => ConfigHelper.Config;

        private SkinFiles SkinFiles { get; set; }
        public OsuSkinningToolsWindow()
        {
            InitializeComponent();

            var configPath = Path.Combine(Directory.GetCurrentDirectory(), "settings.json");
            ConfigHelper = new ConfigurationHelper<Configuration>(configPath);

            SetWorkingDirectory(Config.WorkingDirectory, false);
        }

        private void Btn_SelectWorkingDir_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                SetWorkingDirectory(fbd.SelectedPath);
            }
        }

        private void SetWorkingDirectory(string path, bool showMessage = true)
        {
            if (string.IsNullOrEmpty(path)
                || !Directory.Exists(path)
                || !Directory.GetFiles(path).Any(file => file.Contains("skin.ini")))
            {
                SkinFiles = null;
                if (showMessage)
                {
                    var error = "Please select a valid skin folder.";
                    MessageBox.Show(error);
                    lbl_WorkingDirectory.Text = error;
                }
                return;
            }

            lbl_WorkingDirectory.Text = path;
            ConfigHelper.Config.WorkingDirectory = path;
            SkinFiles = new SkinFiles(Config);
            ConfigHelper.Save();
        }

        private void Btn_CleanLowResAssets_Click(object sender, EventArgs e)
        {
            if (!IsValidWorkingDirectory())
            {
                return;
            }

            progressBar.Maximum = SkinFiles.SdImages.Count - 1;
            progressBar.Value = 0;

            for (int i = 0; i < SkinFiles.SdImages.Count; i++)
            {
                progressBar.Value = i;

                var sdFilename = Path.GetFileNameWithoutExtension(SkinFiles.SdImages[i]) + Config.HighResPattern;

                foreach (var highResAsset in SkinFiles.HdImages)
                {
                    var hdFilename = Path.GetFileNameWithoutExtension(highResAsset);

                    if (sdFilename == hdFilename)
                    {
                        File.Delete(SkinFiles.SdImages[i]);
                    }
                }
            }

            MessageBox.Show("Done");
        }

        private bool IsValidWorkingDirectory()
        {
            if (SkinFiles is null)
            {
                return false;
            }
            return true;
        }

        private void Btn_HDtoSD_Click(object sender, EventArgs e)
        {
            if (!IsValidWorkingDirectory())
            {
                return;
            }

            progressBar.Maximum = SkinFiles.HdImages.Count - 1;
            progressBar.Value = 0;
            //Resizes the images
            for (int i = 0; i < SkinFiles.HdImages.Count; i++)
            {
                progressBar.Value = i;

                var file = SkinFiles.HdImages[i];
                ResizeImage.Resize(file, file.Replace(Config.HighResPattern, string.Empty), Config.ResizeScale);
            }

            MessageBox.Show("Done");

        }
    }
}
