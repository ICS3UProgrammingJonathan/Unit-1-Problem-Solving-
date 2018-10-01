namespace MovingCatJonathanF
{
    partial class frmMovingCat
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
            this.mnuMovingCat = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovingCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMovingCat
            // 
            this.mnuMovingCat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMovingCat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.mnuMovingCat.Location = new System.Drawing.Point(0, 0);
            this.mnuMovingCat.Name = "mnuMovingCat";
            this.mnuMovingCat.Size = new System.Drawing.Size(282, 28);
            this.mnuMovingCat.TabIndex = 0;
            this.mnuMovingCat.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(44, 24);
            this.mniFile.Text = "File";
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(43, 24);
            this.mniCat.Text = "Cat";
            this.mniCat.Click += new System.EventHandler(this.cat1ToolStripMenuItem_Click);
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(181, 26);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.mniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(181, 26);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.mniCat2_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatJonathanF.Properties.Resources.cat2;
            this.picCat.Location = new System.Drawing.Point(68, 65);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(129, 128);
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuMovingCat);
            this.MainMenuStrip = this.mnuMovingCat;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat";
            this.Load += new System.EventHandler(this.frmMovingCat_Load);
            this.mnuMovingCat.ResumeLayout(false);
            this.mnuMovingCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMovingCat;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

