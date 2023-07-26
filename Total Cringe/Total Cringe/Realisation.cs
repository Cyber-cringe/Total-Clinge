using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Cringe
{
    public partial class Realisation : IShow
    {
        public string[]? ShowAllDisk()
        {
            string[]? Drivees;
            DriveInfo[] drives = DriveInfo.GetDrives();
            List<string>? allDrives = new List<string> ();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady && drive != null)
                {
                     allDrives.Add(drive.Name); 
                }
            }
            Drivees = allDrives.ToArray();
            return Drivees;
        }
        public string[]? ShowAllDir(string? disk)
        {            
            List<string>? allDirFiles = new List<string> ();
            try
            {
                string[]? dir = Directory.GetDirectories(disk);
                string[]? fil = Directory.GetFiles(disk);
                foreach (string d in dir)
                {
                    allDirFiles.Add("[Directory]" + d);
                }
                foreach (string? f in fil)
                {
                     allDirFiles.Add(f);
                }
                return allDirFiles.ToArray();
            }
            catch
            {
                MessageBox.Show("Ошибка, вернитесь назад!");
            }
            return allDirFiles.ToArray();
        }
        public string[]? MoveBack(string? ndir, TextBox tb)
        {
            List<string>? allContent = new List<string>();

            try
            {
                if (Directory.Exists(ndir))
                {
                    
                    DirectoryInfo back = Directory.GetParent(ndir);
                    if (back == null)
                    {
                        return null;
                    }
                    string backup = back.FullName.ToString();
                    string[]? content = ShowAllDir(backup);
                    tb.Text = backup;
                    foreach (string? biba in content)
                    {
                        allContent.Add(biba);
                    }
                }
            }
            catch
            {
                MessageBox.Show("b");
            }
            return allContent.ToArray();
        }
        public void dirMaker(string? path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public void filMaker(string? path)
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
        public void Deletant(string? path)
        {
            if (Directory.Exists(path))
            {
                path = path.Replace("[Directory]", "");
                Directory.Delete(path, true);
                return;
            }
            if (File.Exists(path))
            {
                File.Delete(path);
                return;
            }
        }
        public void ShowAndUpdate(string? path, ListBox lb)
        {
            string[]? content = ShowAllDir(path);
            lb.DataSource = content;
        }
    }
}