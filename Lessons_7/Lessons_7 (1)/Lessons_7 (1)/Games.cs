using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_7 // Гордиенко Константин
{
    public partial class Form1 : Form
    {
        int lastEvent = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComand1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            lastEvent = 1;
        }

        private void btnComand2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            lastEvent = 2;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCount.Text = (int.Parse(lblCount.Text) + 1).ToString();
            lastEvent = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Хотите выйти из игры?", "Выход", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Environment.Exit(0);
            } else
            {
                e.Cancel = true;
            }
        }

        private void btnStepBack_Click(object sender, EventArgs e)
        {
            switch (lastEvent)
            {
                case 1:
                    lblNumber.Text = (int.Parse(lblNumber.Text) - 1).ToString();
                    lastEvent = 0;
                    break;
                case 2:
                    lblNumber.Text = (int.Parse(lblNumber.Text) / 2).ToString();
                    lastEvent = 0;
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(100, 999);
            lblInfo3.Text = (int.Parse(lblNumber.Text) + r).ToString();
        }
    }
}
