namespace FormGitTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTask = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(684, 397);
            button2.Name = "button2";
            button2.Size = new Size(43, 39);
            button2.TabIndex = 1;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(739, 393);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnTask
            // 
            btnTask.Location = new Point(498, 404);
            btnTask.Name = "btnTask";
            btnTask.Size = new Size(180, 25);
            btnTask.TabIndex = 4;
            btnTask.Text = "Add Task";
            btnTask.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 448);
            Controls.Add(btnTask);
            Controls.Add(button2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnTask;
    }
}
