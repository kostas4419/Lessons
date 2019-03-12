using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_7__2_
{
    public partial class Form1 : Form
    {
        public int r { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(tbNumber.Text);
            int rNumber = Convert.ToInt32(lblVisible.Text);
            if (answer < rNumber)
            {
                lblAnswer.Text = "Ваше число меньше задуманного";
                lblAnswer.Left = 154;
            } else if (answer > rNumber)
            {
                lblAnswer.Text = "Ваше число больше задуманного";
                lblAnswer.Left = 154;
            } else if (answer == rNumber)
            {
                lblAnswer.Text = "Поздравляем вы угадали число!!!";
                lblAnswer.Left = 154;
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(1, 100);
            lblVisible.Text = Convert.ToString(r);
        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {
            string str = tbNumber.Text;
            bool IsDigit = str.Length == str.Where(c => char.IsDigit(c)).Count();
            if (!IsDigit)
            {
                lblAnswer.Text = "Возможен ввод только положительных чисел";
                lblAnswer.Left = 100;
                btnSend.Enabled = false;
            } else
            {
                btnSend.Enabled = true;
            }
        }
    }
}
