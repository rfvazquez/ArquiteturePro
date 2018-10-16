namespace ArchitecturePro.Componentes
{
    partial class MensagemUsuario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(0, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(268, 28);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMsg
            // 
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsg.ForeColor = System.Drawing.Color.Black;
            this.lblMsg.Location = new System.Drawing.Point(0, 28);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(268, 87);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "label1";
            // 
            // MensagemUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblUsuario);
            this.Name = "MensagemUsuario";
            this.Size = new System.Drawing.Size(268, 115);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMsg;
    }
}
