
namespace WindowsFormsApp1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fOODToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLCOHOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOTDRINKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOLDDRINKSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESSERTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(4);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fOODToolStripMenuItem,
            this.aLCOHOLToolStripMenuItem,
            this.hOTDRINKSToolStripMenuItem,
            this.cOLDDRINKSToolStripMenuItem,
            this.dESSERTSToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip2.Size = new System.Drawing.Size(199, 944);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // fOODToolStripMenuItem
            // 
            this.fOODToolStripMenuItem.Name = "fOODToolStripMenuItem";
            this.fOODToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.fOODToolStripMenuItem.Text = "FOOD";
            // 
            // aLCOHOLToolStripMenuItem
            // 
            this.aLCOHOLToolStripMenuItem.Name = "aLCOHOLToolStripMenuItem";
            this.aLCOHOLToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.aLCOHOLToolStripMenuItem.Text = "ALCOHOL";
            // 
            // hOTDRINKSToolStripMenuItem
            // 
            this.hOTDRINKSToolStripMenuItem.Name = "hOTDRINKSToolStripMenuItem";
            this.hOTDRINKSToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.hOTDRINKSToolStripMenuItem.Text = "HOT DRINKS";
            // 
            // cOLDDRINKSToolStripMenuItem
            // 
            this.cOLDDRINKSToolStripMenuItem.Name = "cOLDDRINKSToolStripMenuItem";
            this.cOLDDRINKSToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.cOLDDRINKSToolStripMenuItem.Text = "COLD DRINKS";
            // 
            // dESSERTSToolStripMenuItem
            // 
            this.dESSERTSToolStripMenuItem.Name = "dESSERTSToolStripMenuItem";
            this.dESSERTSToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.dESSERTSToolStripMenuItem.Text = "DESSERTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fOODToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLCOHOLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOTDRINKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOLDDRINKSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESSERTSToolStripMenuItem;
    }
}

