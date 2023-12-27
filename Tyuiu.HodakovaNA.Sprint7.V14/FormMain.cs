using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.HodakovaNA.Sprint7.V14.Lib;

namespace Tyuiu.HodakovaNA.Sprint7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static string path;
        static string[,] matrix;
        static string[] nums = { };
        DataService ds = new DataService();

        private void button1_Click(object sender, EventArgs e)
        {
            Form2Info formAbout = new Form2Info();
            formAbout.ShowDialog();
        }

        private void But2Help_HNA_Click(object sender, EventArgs e)
        {
            Form3Help formAbout = new Form3Help();
            formAbout.ShowDialog();
        }

        private void But3Tabl_HNA_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialogS7V14_HNA.ShowDialog();
                path = OpenFileDialogS7V14_HNA.FileName;

                matrix = ds.GetMatrix(path);

                for (int i = 1; i < matrix.GetLength(0) - 1; i++)
                {
                    ComboBox1Marsh_HNA.Items.Add(Convert.ToString(matrix[i, 0]));
                    nums.Append(Convert.ToString(matrix[i, 0]));
                }
                But2Go_HNA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1Num_HNA_Click(object sender, EventArgs e)
        {

        }

        private void But2Go_HNA_Click(object sender, EventArgs e)
        {
            Label1Num_HNA.Visible = true;
            Label2Start_HNA.Visible = true;
            Label3Finish_HNA.Visible = true;
            Label4Dlina_HNA.Visible = true;
            Label5DataNach_HNA.Visible = true;
            Lab0VidTrans_HNA.Visible = true;

            try
            {
                int k = ComboBox1Marsh_HNA.SelectedIndex + 1;

                Lab0VidTrans_Fix_HNA.Text = Convert.ToString(matrix[k, 1]);
                Label1Num_Fix_HNA.Text = Convert.ToString(matrix[k, 0]);
                Label2Start_Fix_HNA.Text = Convert.ToString(matrix[k, 2]);
                Label3Finish_Fix_HNA.Text = Convert.ToString(matrix[k, 3]);
                Label4Dlina_Fix_HNA.Text = Convert.ToString(matrix[k, 4] + " км");
                Label5DataNach_Fix_HNA.Text = Convert.ToString(matrix[k, 5]);

            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
