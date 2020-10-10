using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Prototype
{
    public partial class Select_form : Form
    {
        Translation_form next_form = new Translation_form();
        public Select_form()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            String date = "";
            StreamWriter sw = new StreamWriter("data.txt");
            date = day.Text + " " + mouth.Text + " " + year.Text;
            sw.WriteLine(type.Text);
            sw.WriteLine(number.Text);
            sw.WriteLine(date);
            sw.WriteLine(toppic.Text);
            sw.WriteLine(to.Text);
            sw.WriteLine(name.Text);
            sw.WriteLine(position.Text);
            sw.Close();
            StreamWriter wad = new StreamWriter("address.txt");
            wad.WriteLine(address.Text);
            wad.Close();
            this.Hide();
            next_form.ShowDialog();
            this.Show();

        }

        private void Select_form_Load(object sender, EventArgs e)
        {

        }
    }
}
