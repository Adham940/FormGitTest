using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGitTest
{
    public partial class Form2 : Form
    {
        public string ButtonName { get; private set; }
        public Form2()
        {
            InitializeComponent();
            this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonName = textBox1.Text.Trim();
            this.Close();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
