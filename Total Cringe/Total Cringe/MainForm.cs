using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace Total_Cringe
{
    public partial class MainForm : Form
    {
        string? path;
        public MainForm()
        {
            InitializeComponent();
            Realisation realisation = new Realisation();
            string[]? drives = realisation.ShowAllDisk();
            foreach (string? drive in drives)
            {
                DiskBox.Items.Add(drive);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox drivs = sender as ComboBox;
            WayBox.Text = drivs.SelectedItem.ToString();

            Realisation realisation = new Realisation();
            string? disk = drivs.SelectedItem.ToString();
            string[]? content = realisation.ShowAllDir(disk);
            ContentBox.DataSource = content;
        }
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (ContentBox.SelectedItem == null) return;
            if (ContentBox.SelectedItem.ToString().StartsWith("[Directory]"))
            {
                WayBox.Text = ContentBox.SelectedItem.ToString().Remove(0, 11);
                Realisation realisation = new Realisation();
                string? newpath = WayBox.Text;
                string[]? content = realisation.ShowAllDir(newpath);
                ContentBox.DataSource = content;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Realisation realisation = new Realisation();
            CreationForm creationForm = new CreationForm(WayBox.Text);
            creationForm.upd ((object aboba, EventArgs biba) => realisation.ShowAndUpdate(WayBox.Text, ContentBox));
            
            creationForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (ContentBox.SelectedItem == null) return;

            if (ContentBox.SelectedItem.ToString().StartsWith("[Directory]"))
            {
                WayBox.Text = ContentBox.SelectedItem.ToString().Remove(0, 11);
                Realisation realisation = new Realisation();
                DeleteForm deleteForm = new DeleteForm(ContentBox.SelectedItem.ToString());
                deleteForm.upd ((object bibis, EventArgs nibbis) => realisation.ShowAndUpdate(WayBox.Text, ContentBox));
                deleteForm.Show();
            }
            else
            {
                Realisation realisation = new Realisation();
                DeleteForm deleteForm = new DeleteForm(ContentBox.SelectedItem.ToString());
                deleteForm.upd((object bibis, EventArgs nibbis) => realisation.ShowAndUpdate(WayBox.Text, ContentBox));
                deleteForm.Show();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            path = WayBox.Text;
            Realisation realisation = new Realisation();
            string[]? content = null;
            if (Directory.Exists(path))
            {
                content = realisation.MoveBack(path, WayBox);
            }

            if (content == null) return;
            ContentBox.DataSource = content;
        }
    }
}