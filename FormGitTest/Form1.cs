namespace FormGitTest
{
    public partial class Form1 : Form
    {
        int buttonCount = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();


            Button newButton = new Button();
            newButton.Text = frm2.ButtonName;
            newButton.Size = new Size(175, 123);

            flowLayoutPanel1.Controls.Add(newButton);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus)
            {
                button2.PerformClick();
            }

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TAskForm task = new TAskForm();
            task.ShowDialog();
            
        }
    }
}
