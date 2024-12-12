namespace LB3_Blog
{
    partial class FormMain
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
            dataGridViewUsers = new DataGridView();
            buttonSave = new Button();
            panelTop = new Panel();
            panelLeft = new Panel();
            panel1 = new Panel();
            dataGridViewPosts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(10, 10);
            dataGridViewUsers.Margin = new Padding(4);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(510, 540);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.SelectionChanged += DataGridViewUsers_SelectionChanged;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Location = new Point(10, 10);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 50);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonSave);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1029, 70);
            panelTop.TabIndex = 2;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(dataGridViewUsers);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 70);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10);
            panelLeft.Size = new Size(530, 560);
            panelLeft.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridViewPosts);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(530, 70);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(499, 560);
            panel1.TabIndex = 4;
            // 
            // dataGridViewPosts
            // 
            dataGridViewPosts.BackgroundColor = Color.White;
            dataGridViewPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPosts.Dock = DockStyle.Fill;
            dataGridViewPosts.Location = new Point(10, 10);
            dataGridViewPosts.Name = "dataGridViewPosts";
            dataGridViewPosts.Size = new Size(479, 540);
            dataGridViewPosts.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(panel1);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPosts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button buttonSave;
        private Panel panelTop;
        private Panel panelLeft;
        private Panel panel1;
        private DataGridView dataGridViewPosts;
    }
}
