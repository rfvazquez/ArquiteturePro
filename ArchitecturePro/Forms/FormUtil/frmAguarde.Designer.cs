namespace ArchitecturePro.Forms.FormUtil
{
    partial class frmAguarde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAguarde));
            this.lblImgAguarde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImgAguarde
            // 
            this.lblImgAguarde.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblImgAguarde.Image = ((System.Drawing.Image)(resources.GetObject("lblImgAguarde.Image")));
            this.lblImgAguarde.Location = new System.Drawing.Point(0, 0);
            this.lblImgAguarde.Name = "lblImgAguarde";
            this.lblImgAguarde.Size = new System.Drawing.Size(76, 120);
            this.lblImgAguarde.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(85, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aguarde...";
            // 
            // frmAguarde
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblImgAguarde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAguarde";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aguarde...........";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAguarde_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImgAguarde;
        private System.Windows.Forms.Label label1;
    }
}