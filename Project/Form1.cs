using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admins.cfg_Entry_Generator_by_aIM
{
    public partial class Form1 : Form
    {
        string FileGroups, FileNoGroups;

        public Form1()
        {
            InitializeComponent();
            textBox4.Enabled = false;
            textBox2.Enabled = false;

            richTextBox2.Visible = false;

            FileGroups = richTextBox2.Text;
            FileNoGroups = richTextBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                numericUpDown1.Enabled = false;
                richTextBox1.Visible = false;
                richTextBox2.Visible = true;
            }
            else
            {
                textBox4.Enabled = false;
                textBox5.Enabled = true;
                numericUpDown1.Enabled = true;
                richTextBox2.Visible = false;
                richTextBox1.Visible = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            /*       var sb = new StringBuilder();
                   var sb2 = new StringBuilder();
                   System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Program Files\SourceMod Tool\test.txt");
                   while ((FileGroups = file.ReadLine()) != null)
                       sb.AppendLine(FileGroups.Substring(0, Math.Min(38, FileGroups.Length)));

                   file.Close();
                   System.IO.StreamReader file2 = new System.IO.StreamReader(@"C:\Program Files\SourceMod Tool\test2.txt");
                   while ((FileNoGroups = file2.ReadLine()) != null)
                       sb2.AppendLine(FileNoGroups.Substring(0, Math.Min(38, FileNoGroups.Length)));
                   file2.Close();*/


            string Result;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                Result = WriteEntryGroups(FileGroups, textBox1.Text, comboBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, checkBox2);
                richTextBox2.Clear();
                richTextBox2.AppendText(Result);
            }
            else
            {
                Result = WriteEntryNoGroups(FileNoGroups, textBox1.Text, comboBox1.Text, textBox3.Text, textBox5.Text, numericUpDown1.Value.ToString(), textBox2.Text, checkBox2);
                richTextBox1.Clear();
                richTextBox1.AppendText(Result);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }

        static string WriteEntryGroups(string a, string txtbox1, string txtbox2, string txtbox3, string txtbox4, string txtbox5, CheckBox chkbox)
        {
            StringBuilder b = new StringBuilder(a);

            b.Replace("adminname", txtbox1);
            b.Replace("method", txtbox2);
            b.Replace("steamid", txtbox3);
            b.Replace("groupname", txtbox4);

            if (chkbox.CheckState == CheckState.Checked)
            {
                b.Insert(b.Length - 1, @"	""password""		""adminpw""" + Environment.NewLine);
                b.Replace("adminpw", txtbox5);
            }

            return b.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://steamidfinder.com/");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                richTextBox2.SelectAll();
                richTextBox2.Copy();
            }
            else
            {
                richTextBox2.SelectAll();
                richTextBox2.Copy();
            }
        }

        static string WriteEntryNoGroups(string a, string txtbox1, string txtbox2, string txtbox3, string txtbox4, string txtbox5, string txtbox6, CheckBox chkbox)
        {
            StringBuilder b = new StringBuilder(a);

            b.Replace("adminname", txtbox1);
            b.Replace("method", txtbox2);
            b.Replace("steamid", txtbox3);
            b.Replace("adminflags", txtbox4);
            b.Replace("immunitylvl", txtbox5);

            if (chkbox.CheckState == CheckState.Checked)
            {
                b.Insert(b.Length - 1, @"	""password""		""adminpw""" + Environment.NewLine);
                b.Replace("adminpw", txtbox6);
            }

            return b.ToString();
        }
    }
}
