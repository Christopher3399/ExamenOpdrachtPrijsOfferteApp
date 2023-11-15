namespace PrijsOfferteApp
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
            menuStrip1 = new MenuStrip();
            openApplicationToolStripMenuItem = new ToolStripMenuItem();
            closeApplicationToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openApplicationToolStripMenuItem, closeApplicationToolStripMenuItem, showToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(770, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // openApplicationToolStripMenuItem
            // 
            openApplicationToolStripMenuItem.Name = "openApplicationToolStripMenuItem";
            openApplicationToolStripMenuItem.Size = new Size(104, 20);
            openApplicationToolStripMenuItem.Text = "Open Applicatie";
            openApplicationToolStripMenuItem.Click += openApplicationToolStripMenuItem_Click;
            // 
            // closeApplicationToolStripMenuItem
            // 
            closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            closeApplicationToolStripMenuItem.Size = new Size(98, 20);
            closeApplicationToolStripMenuItem.Text = "Sluit Applicatie";
            closeApplicationToolStripMenuItem.Click += closeApplicationToolStripMenuItem_Click;
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(91, 20);
            showToolStripMenuItem.Text = "Toon Tabellen";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 316);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "HomeScreen";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openApplicationToolStripMenuItem;
        private ToolStripMenuItem closeApplicationToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
    }


}