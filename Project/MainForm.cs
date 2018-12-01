using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using System.Runtime.InteropServices;

namespace OpenAsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region Map tooltips
            Dictionary<string, List<Control>> grouped_controls = new Dictionary<string, List<Control>>();
            foreach (Control control in Controls)
            {
                string[] _key = control.Name.Split('_');
                _key = _key.SubArray(0, _key.Length - 1);
                string key = _key.Stitch('_');

                if (!grouped_controls.ContainsKey(key))
                    grouped_controls.Add(key, new List<Control>());
                grouped_controls[key].Add(control);
            }

            foreach (string key in grouped_controls.Keys)
            {
                List<Control> group = grouped_controls[key];

                // Enumerate through i until it finds the control with the tooltip
                int i = 0;
                while (i < group.Count)
                {
                    if (toolTip1.GetToolTip(group[i]) == "")
                        i++;
                    else
                        break;
                }

                for (int i2 = 0; i2 < group.Count; i2++)
                {
                    if (i == i2) continue;
                    else
                        if (toolTip1.GetToolTip(group[i2]) == "")
                            toolTip1.SetToolTip(group[i2], toolTip1.GetToolTip(group[i]));
                }
            }
            #endregion
        }

        [DllImport("Shell32.dll")]
        private static extern int SHGetKnownFolderPath(int rfid, int dwflags, string access_token, string ppszPath);

        private string Get_shortcut_path()
        {
            string result = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + '\\' + Shortcut_name_TextBox.Text + ".lnk";
            return result;
        }

        private string Get_website_address()
        {
            string result = Website_address_TextBox.Text;
            if (!(result.Substring(0, 8) == "https://" || result.Substring(0, 7) == "http://"))
                result = "http" + (Use_HTTPS_CheckBox.Checked ? "s" : "") + "://" + result;
            return result;
        }

        private void Create_shortcut()
        {
            if (System.IO.File.Exists(Get_shortcut_path()) ? 
                MessageBox.Show("The shortcut \"" + Shortcut_name_TextBox.Text + "\" already exists. Are you sure you want to overwrite it?", "Shortcut already exists", MessageBoxButtons.YesNo) == DialogResult.Yes
                : true)
            {
                WshShell shell = new WshShell();
                WshShortcut shortcut = shell.CreateShortcut(Get_shortcut_path());
                shortcut.TargetPath = "C:\\Program Files" + (System.IO.Directory.Exists("C:\\Program Files (x86)") ? " (x86)" : "") + @"\Google\Chrome\Application\chrome.exe";
                shortcut.Arguments = "--profile-directory=Default --app=\"" + Get_website_address() + "\"";
                shortcut.Save();
                MessageBox.Show("Shortcut created");
            }
        }

        private void Create_shortcut_Button_Click(object sender, EventArgs e)
        {
            Create_shortcut();
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Create_shortcut();
        }
    }
}
