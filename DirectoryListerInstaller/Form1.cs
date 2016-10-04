using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryListerInstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string menuName = "Folder\\shell\\DirectoryLister";
        private const string command = "Folder\\shell\\DirectoryLister\\command";

        private void installBtn_Click(object sender, EventArgs e)
        {
            RegistryKey regmenu = null;
            RegistryKey regcmd = null;
            try
            {
                //Add the registry entries
                regmenu = Registry.ClassesRoot.CreateSubKey(menuName);
                if (regmenu != null)
                    regmenu.SetValue("", "Show subfolders info");
                regcmd = Registry.ClassesRoot.CreateSubKey(command);
                if (regcmd != null)
                    regcmd.SetValue("", @"C:\Windows\DirectoryLister.exe" + " \"%L\"");
                //Copy the main executable to the Windows directory
                string currentPath = System.IO.Directory.GetCurrentDirectory();
                string fullFilePath = currentPath + @"\DirectoryLister.exe";
                string destinationFilePath = @"C:\Windows\DirectoryLister.exe";
                System.IO.File.Copy(fullFilePath, destinationFilePath, true);
                MessageBox.Show(this, "Installed successfully.", "Directory Lister");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error during installation. Is the DirectoryLister.exe file in the same location as the installer?", "Error");
            }
            finally
            {
                if (regmenu != null)
                    regmenu.Close();
                if (regcmd != null)
                    regcmd.Close();
            }

        }

        private void uninstallBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Remove the registry entries
                RegistryKey reg = Registry.ClassesRoot.OpenSubKey(command);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(command);
                }
                reg = Registry.ClassesRoot.OpenSubKey(menuName);
                if (reg != null)
                {
                    reg.Close();
                    Registry.ClassesRoot.DeleteSubKey(menuName);
                }
                //Remove the main executable from the Windows directory
                string filePath = @"C:\Windows\DirectoryLister.exe";
                System.IO.File.Delete(filePath);
                MessageBox.Show(this, "Unsintallation successful.", "Directory Lister");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error uninstalling.", "Error");
                MessageBox.Show(this, ex.ToString());
            }
        }
    }
}
