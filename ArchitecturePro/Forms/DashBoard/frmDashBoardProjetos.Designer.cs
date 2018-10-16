namespace ArchitecturePro.Forms.DashBoard
{
    partial class frmDashBoardProjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashBoardProjetos));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlDash = new System.Windows.Forms.Panel();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnAtualizar);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 185);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(619, 77);
            this.pnlBotoes.TabIndex = 6;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(469, 0);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 77);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "&Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(544, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlDash
            // 
            this.pnlDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDash.Location = new System.Drawing.Point(0, 0);
            this.pnlDash.Name = "pnlDash";
            this.pnlDash.Size = new System.Drawing.Size(619, 185);
            this.pnlDash.TabIndex = 7;
            // 
            // frmDashBoardProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 262);
            this.Controls.Add(this.pnlDash);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashBoardProjetos";
            this.Text = "DashBoard Projetos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashBoardProjetos_FormClosed);
            this.Load += new System.EventHandler(this.frmDashBoardProjetos_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlDash;
        private System.Windows.Forms.Button btnAtualizar;
    }
}