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

namespace Total_Cringe
{
    public partial class CreationForm : Form
    {
        public enum tipis
        {
            Папка, Файл
        }

        string way;
        public CreationForm(string path)
        {
            InitializeComponent();
            way = path;
            TypeBox.Items.Add(tipis.Папка);
            TypeBox.Items.Add(tipis.Файл);
        }

        public void batton1_Click_1(object sender, EventArgs e) 
        {
            showFunc(way);
            this.Close();
        }

        public void showFunc(string path)
        {
            path = path + "/" + NameBox.Text;
            Realisation realisation = new Realisation();

            switch (TypeBox.SelectedItem)
            {
                case tipis.Папка:
                    realisation.dirMaker(path);
                    break;
                case tipis.Файл:
                    realisation.filMaker(path);
                    break;
                default:
                    MessageBox.Show("Необходимо выбрать тип");
                    return;
            }
        }
        public void upd(EventHandler bib) => OKbutton.Click += bib;
    }
}
