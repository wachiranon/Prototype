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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Linq.Expressions;


namespace Prototype
{
    public partial class Translation_form : Form
    {
        public String t = "";
        public String number = "";
        public String address = "";
        public String date = "";
        public String toppic = "";
        public String to = "";
        public String name = "";
        public String position = "";
        //iTextSharp.text.Font mainFont = FontFactory.GetFont("TH Sarabun New", 14, new iTextSharp.text.BaseColor(System.Drawing.ColorTranslator.FromHtml("#000")));
        // BaseFont ThSaraban = BaseFont.CreateFont(@"E:\\Work\\com\\499\\cut_and_transformation\\Prototype\\Prototype\\bin\\Debug\\THSarabunNew.ttf", BaseFont.IDENTITY_H,BaseFont.NOT_EMBEDDED);
        int fontsize = 16;
        

        public Translation_form()
        {
            InitializeComponent();          
        }


        private void Transaletion_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter("Input.txt");
            sw.WriteLine(textBox1.Text);
            sw.Close();
            //Process.Start("E:\\Work\\com\\499\\cut_and_transformation\\Prototype\\Prototype\\bin\\Debug\\Transaletion.py");
            //Process.Start("E:\\Work\\com\\499\\cut_and_transformation\\Prototype\\Prototype\\bin\\Debug\\Transaletion_deepcut.py");
            System.Diagnostics.Process.Start(@"Transaletion.py");
            System.Diagnostics.Process.Start(@"Transaletion_deepcut.py");

        }

        private void show_Click(object sender, EventArgs e)
        {
            //FileStream f = File.Open()
            if (translation_type.Text == "คัดคำ - cutkum")
            {
                StreamReader sr = new StreamReader("Output_cutkum.txt");
                String t = sr.ReadToEnd();
                textBox2.Text = t;
                sr.Close();
            }
            else if(translation_type.Text == "ดีพคัด - deepcut")
            {
                StreamReader sr = new StreamReader("Output_deepcut.txt");
                String t = sr.ReadToEnd();
                textBox2.Text = t;
                sr.Close();
            }
            
            
        }

        private void make_Click(object sender, EventArgs e)
        {
            StreamReader data = new StreamReader("data.txt");
            t = data.ReadLine();
            number = data.ReadLine();
            date = data.ReadLine();
            toppic = data.ReadLine();
            to = data.ReadLine();
            name = data.ReadLine();
            position = data.ReadLine();
            data.Close();
            StreamReader ad = new StreamReader("address.txt");
            address = ad.ReadToEnd();

            StreamWriter doc = new StreamWriter("Document.txt");
            doc.WriteLine("ชนิดเอกสาร : " + t);
            doc.WriteLine("เลขเอกสาร : " + number);
            doc.Write("\nที่อยู่ : \n" + address + "\n");
            doc.WriteLine("วันที่ : " + date);
            doc.WriteLine("เรื่อง : " + toppic);
            doc.WriteLine("เรียน : " + to);
            doc.Write("\nเนื้อความ : \n" + textBox2.Text + "\n");
            doc.WriteLine("ผู้ลงนาม : (" + name + ")");
            doc.WriteLine("ตำแหน่ง : " + position);
            doc.Close();
        }
    }
}
