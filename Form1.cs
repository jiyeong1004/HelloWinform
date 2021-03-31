using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sender.Equals(button1))
            {
                MessageBox.Show("첫 번째 버튼 와우!");
            }
            else
            {
                MessageBox.Show("두 번째 버튼 와우!");
            }
        }
    }
}
