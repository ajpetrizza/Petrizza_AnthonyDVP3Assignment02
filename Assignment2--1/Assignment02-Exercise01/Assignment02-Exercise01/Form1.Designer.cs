namespace Assignment02_Exercise01
{
    partial class Form1
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
            this.listBoxWant = new System.Windows.Forms.ListBox();
            this.listBoxNeed = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoveToNeed = new System.Windows.Forms.Button();
            this.btnDeleteWant = new System.Windows.Forms.Button();
            this.btnAddWant = new System.Windows.Forms.Button();
            this.textBoxWant = new System.Windows.Forms.TextBox();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAddNeed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxWant
            // 
            this.listBoxWant.FormattingEnabled = true;
            this.listBoxWant.ItemHeight = 16;
            this.listBoxWant.Location = new System.Drawing.Point(16, 91);
            this.listBoxWant.Name = "listBoxWant";
            this.listBoxWant.Size = new System.Drawing.Size(259, 260);
            this.listBoxWant.TabIndex = 0;
            // 
            // listBoxNeed
            // 
            this.listBoxNeed.FormattingEnabled = true;
            this.listBoxNeed.ItemHeight = 16;
            this.listBoxNeed.Location = new System.Drawing.Point(294, 91);
            this.listBoxNeed.Name = "listBoxNeed";
            this.listBoxNeed.Size = new System.Drawing.Size(283, 260);
            this.listBoxNeed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wants:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Needs";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnMoveToNeed
            // 
            this.btnMoveToNeed.Location = new System.Drawing.Point(96, 399);
            this.btnMoveToNeed.Name = "btnMoveToNeed";
            this.btnMoveToNeed.Size = new System.Drawing.Size(75, 23);
            this.btnMoveToNeed.TabIndex = 5;
            this.btnMoveToNeed.Text = "Move";
            this.btnMoveToNeed.UseVisualStyleBackColor = true;
            this.btnMoveToNeed.Click += new System.EventHandler(this.btnMoveToNeed_Click);
            // 
            // btnDeleteWant
            // 
            this.btnDeleteWant.Location = new System.Drawing.Point(202, 399);
            this.btnDeleteWant.Name = "btnDeleteWant";
            this.btnDeleteWant.Size = new System.Drawing.Size(183, 33);
            this.btnDeleteWant.TabIndex = 6;
            this.btnDeleteWant.Text = "Delete";
            this.btnDeleteWant.UseVisualStyleBackColor = true;
            this.btnDeleteWant.Click += new System.EventHandler(this.btnDeleteWant_Click);
            // 
            // btnAddWant
            // 
            this.btnAddWant.Location = new System.Drawing.Point(16, 399);
            this.btnAddWant.Name = "btnAddWant";
            this.btnAddWant.Size = new System.Drawing.Size(75, 23);
            this.btnAddWant.TabIndex = 7;
            this.btnAddWant.Text = "Add";
            this.btnAddWant.UseVisualStyleBackColor = true;
            this.btnAddWant.Click += new System.EventHandler(this.btnAddWant_Click);
            // 
            // textBoxWant
            // 
            this.textBoxWant.Location = new System.Drawing.Point(16, 371);
            this.textBoxWant.Name = "textBoxWant";
            this.textBoxWant.Size = new System.Drawing.Size(155, 22);
            this.textBoxWant.TabIndex = 8;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(422, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 9;
            // 
            // btnAddNeed
            // 
            this.btnAddNeed.Location = new System.Drawing.Point(422, 399);
            this.btnAddNeed.Name = "btnAddNeed";
            this.btnAddNeed.Size = new System.Drawing.Size(75, 23);
            this.btnAddNeed.TabIndex = 10;
            this.btnAddNeed.Text = "Add";
            this.btnAddNeed.UseVisualStyleBackColor = true;
            this.btnAddNeed.Click += new System.EventHandler(this.btnAddNeed_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Move";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddNeed);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxWant);
            this.Controls.Add(this.btnAddWant);
            this.Controls.Add(this.btnDeleteWant);
            this.Controls.Add(this.btnMoveToNeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNeed);
            this.Controls.Add(this.listBoxWant);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWant;
        private System.Windows.Forms.ListBox listBoxNeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnMoveToNeed;
        private System.Windows.Forms.Button btnDeleteWant;
        private System.Windows.Forms.Button btnAddWant;
        private System.Windows.Forms.TextBox textBoxWant;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAddNeed;
        private System.Windows.Forms.Button button1;
    }
}

