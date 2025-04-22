namespace FormGitTest
{
    partial class TAskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnRemove = new Button();
            Tasks = new CheckedListBox();
            tbxAdd = new TextBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(196, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(185, 61);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(196, 125);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(185, 65);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // Tasks
            // 
            Tasks.FormattingEnabled = true;
            Tasks.Location = new Point(21, 13);
            Tasks.Name = "Tasks";
            Tasks.Size = new Size(150, 202);
            Tasks.TabIndex = 2;
            // 
            // tbxAdd
            // 
            tbxAdd.Location = new Point(196, 13);
            tbxAdd.Name = "tbxAdd";
            tbxAdd.Size = new Size(213, 27);
            tbxAdd.TabIndex = 3;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 240);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(150, 29);
            progressBar1.TabIndex = 4;
            // 
            // TAskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 375);
            Controls.Add(progressBar1);
            Controls.Add(tbxAdd);
            Controls.Add(Tasks);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "TAskForm";
            Text = "TaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private CheckedListBox Tasks;
        private TextBox tbxAdd;
        private ProgressBar progressBar1;
    }
}