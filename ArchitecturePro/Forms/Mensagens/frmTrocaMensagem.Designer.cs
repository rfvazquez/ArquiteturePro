namespace ArchitecturePro.Forms.Mensagens
{
    partial class frmTrocaMensagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrocaMensagem));
            this.pnlEnvio = new System.Windows.Forms.Panel();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pnlConversa = new System.Windows.Forms.Panel();
            this.pnlEnvio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEnvio
            // 
            this.pnlEnvio.Controls.Add(this.txtMsg);
            this.pnlEnvio.Controls.Add(this.btnEnviar);
            this.pnlEnvio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEnvio.Location = new System.Drawing.Point(0, 350);
            this.pnlEnvio.Name = "pnlEnvio";
            this.pnlEnvio.Size = new System.Drawing.Size(378, 54);
            this.pnlEnvio.TabIndex = 0;
            // 
            // txtMsg
            // 
            this.txtMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsg.Location = new System.Drawing.Point(0, 0);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(324, 54);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            this.txtMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMsg_KeyDown);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(324, 0);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(54, 54);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // pnlConversa
            // 
            this.pnlConversa.AutoScroll = true;
            this.pnlConversa.BackColor = System.Drawing.SystemColors.Control;
            this.pnlConversa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConversa.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlConversa.Location = new System.Drawing.Point(0, 0);
            this.pnlConversa.Name = "pnlConversa";
            this.pnlConversa.Size = new System.Drawing.Size(378, 350);
            this.pnlConversa.TabIndex = 2;
            // 
            // frmTrocaMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 404);
            this.Controls.Add(this.pnlConversa);
            this.Controls.Add(this.pnlEnvio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrocaMensagem";
            this.Text = "Conversa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTrocaMensagem_FormClosed);
            this.Load += new System.EventHandler(this.frmTrocaMensagem_Load);
            this.pnlEnvio.ResumeLayout(false);
            this.pnlEnvio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEnvio;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Panel pnlConversa;
    }
}