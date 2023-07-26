using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Total_Cringe
{
    public delegate void Deleter(string path);
    public partial class DeleteForm : Form
    {
        string way;
        public DeleteForm(string path)
        {
            InitializeComponent();
            way = path;
        }

        public static event Deleter Delt;
        private void button1_Click(object sender, EventArgs e)
        {
            Realisation realisation = new Realisation();
            Delt += realisation.Deletant;
            Delt(way);
            this.Close();
        }
        public void upd(EventHandler bib) => button1.Click += bib;
    }
}
