using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lessons_7
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        { 
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }
    }
}
