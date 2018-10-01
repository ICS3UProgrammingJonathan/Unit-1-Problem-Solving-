namespace SchoolMascot
{
    partial class frmSchoolMascot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchoolMascot));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSchoolNames = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAshbury = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGlebe = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblSchoolMascot = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSchoolNames});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuSchoolNames
            // 
            this.mnuSchoolNames.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniAshbury,
            this.mniGlebe});
            this.mnuSchoolNames.Name = "mnuSchoolNames";
            this.mnuSchoolNames.Size = new System.Drawing.Size(72, 24);
            this.mnuSchoolNames.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(181, 26);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniAshbury
            // 
            this.mniAshbury.Name = "mniAshbury";
            this.mniAshbury.Size = new System.Drawing.Size(181, 26);
            this.mniAshbury.Text = "Ashbury";
            this.mniAshbury.Click += new System.EventHandler(this.mniAshbury_Click);
            // 
            // mniGlebe
            // 
            this.mniGlebe.Name = "mniGlebe";
            this.mniGlebe.Size = new System.Drawing.Size(181, 26);
            this.mniGlebe.Text = "Glebe";
            this.mniGlebe.Click += new System.EventHandler(this.mniGlebe_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblSchoolMascot
            // 
            this.lblSchoolMascot.AutoSize = true;
            this.lblSchoolMascot.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolMascot.Location = new System.Drawing.Point(134, 103);
            this.lblSchoolMascot.Name = "lblSchoolMascot";
            this.lblSchoolMascot.Size = new System.Drawing.Size(332, 48);
            this.lblSchoolMascot.TabIndex = 2;
            this.lblSchoolMascot.Text = "School Mascot";
            this.lblSchoolMascot.Click += new System.EventHandler(this.lblSchoolMascotMenu_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(586, 283);
            this.Controls.Add(this.lblSchoolMascot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSchoolMascot";
            this.Text = "SchoolMascot";
            this.Load += new System.EventHandler(this.frmSchoolMascot_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSchoolNames;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniAshbury;
        private System.Windows.Forms.ToolStripMenuItem mniGlebe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblSchoolMascot;
    }
}

