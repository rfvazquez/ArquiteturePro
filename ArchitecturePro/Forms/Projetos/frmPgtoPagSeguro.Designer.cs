namespace ArchitecturePro.Forms.Projetos
{
    partial class frmPgtoPagSeguro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPgtoPagSeguro));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnWhatsApp = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnWhatsApp);
            this.pnlBotoes.Controls.Add(this.btnEmail);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 294);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(438, 77);
            this.pnlBotoes.TabIndex = 27;
            // 
            // btnEmail
            // 
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmail.Location = new System.Drawing.Point(363, 0);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 77);
            this.btnEmail.TabIndex = 3;
            this.btnEmail.Text = "&Email";
            this.btnEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 103);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(414, 176);
            this.txtMensagem.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mensagem";
            // 
            // txtMailCliente
            // 
            this.txtMailCliente.Location = new System.Drawing.Point(12, 25);
            this.txtMailCliente.Name = "txtMailCliente";
            this.txtMailCliente.Size = new System.Drawing.Size(413, 20);
            this.txtMailCliente.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "E-Mail Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Celular Cliente";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 64);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(146, 20);
            this.txtTelefone.TabIndex = 33;
            // 
            // btnWhatsApp
            // 
            this.btnWhatsApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWhatsApp.Image = ((System.Drawing.Image)(resources.GetObject("btnWhatsApp.Image")));
            this.btnWhatsApp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWhatsApp.Location = new System.Drawing.Point(288, 0);
            this.btnWhatsApp.Name = "btnWhatsApp";
            this.btnWhatsApp.Size = new System.Drawing.Size(75, 77);
            this.btnWhatsApp.TabIndex = 5;
            this.btnWhatsApp.Text = "&WhatsApp";
            this.btnWhatsApp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWhatsApp.UseVisualStyleBackColor = true;
            this.btnWhatsApp.Click += new System.EventHandler(this.btnWhatsApp_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(213, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // frmPgtoPagSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 371);
            this.ControlBox = false;
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMailCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBotoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPgtoPagSeguro";
            this.Text = "Enviar Informações PagSeguro";
            this.Load += new System.EventHandler(this.frmPgtoPagSeguro_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMailCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnWhatsApp;
        private System.Windows.Forms.Button btnSair;
    }
}