namespace take_home_edwardsuwandi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneljam = new System.Windows.Forms.Panel();
            this.panelseat = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.paneljam);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1461, 1031);
            this.panel1.TabIndex = 0;
            // 
            // paneljam
            // 
            this.paneljam.AutoScroll = true;
            this.paneljam.Location = new System.Drawing.Point(0, 0);
            this.paneljam.Name = "paneljam";
            this.paneljam.Size = new System.Drawing.Size(1461, 158);
            this.paneljam.TabIndex = 1;
            // 
            // panelseat
            // 
            this.panelseat.Location = new System.Drawing.Point(12, 170);
            this.panelseat.Name = "panelseat";
            this.panelseat.Size = new System.Drawing.Size(1461, 873);
            this.panelseat.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 1055);
            this.Controls.Add(this.panelseat);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelseat;
        private System.Windows.Forms.Panel paneljam;
    }
}

