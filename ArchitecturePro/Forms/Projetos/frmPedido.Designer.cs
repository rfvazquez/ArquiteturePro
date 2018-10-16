namespace ArchitecturePro.Forms.Projetos
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pnlImprimir = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.gbxDetalhamento = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNOrcamento = new System.Windows.Forms.Label();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pnlBotoes.SuspendLayout();
            this.pnlImprimir.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxDetalhamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(749, 31);
            this.pnlBotoes.TabIndex = 27;
            this.pnlBotoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBotoes_Paint);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(599, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 31);
            this.btnSair.TabIndex = 4;
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(674, 0);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pnlImprimir
            // 
            this.pnlImprimir.Controls.Add(this.panel2);
            this.pnlImprimir.Controls.Add(this.panel1);
            this.pnlImprimir.Controls.Add(this.groupBox1);
            this.pnlImprimir.Controls.Add(this.gbxDetalhamento);
            this.pnlImprimir.Controls.Add(this.label2);
            this.pnlImprimir.Controls.Add(this.lblNOrcamento);
            this.pnlImprimir.Controls.Add(this.lblDadosCliente);
            this.pnlImprimir.Controls.Add(this.label1);
            this.pnlImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImprimir.Location = new System.Drawing.Point(0, 31);
            this.pnlImprimir.Name = "pnlImprimir";
            this.pnlImprimir.Size = new System.Drawing.Size(749, 711);
            this.pnlImprimir.TabIndex = 28;
            this.pnlImprimir.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlImprimir_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cornsilk;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(16, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 34);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dados do Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 34);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(441, 5);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(270, 24);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Orçamento Final";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Orçamento Final";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblObs);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 583);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações";
            // 
            // lblObs
            // 
            this.lblObs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(3, 25);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(708, 92);
            this.lblObs.TabIndex = 5;
            this.lblObs.Text = "Item";
            // 
            // gbxDetalhamento
            // 
            this.gbxDetalhamento.Controls.Add(this.lblValor);
            this.gbxDetalhamento.Controls.Add(this.lblQtde);
            this.gbxDetalhamento.Controls.Add(this.lblDescricao);
            this.gbxDetalhamento.Controls.Add(this.lblItem);
            this.gbxDetalhamento.Controls.Add(this.label8);
            this.gbxDetalhamento.Controls.Add(this.label7);
            this.gbxDetalhamento.Controls.Add(this.label6);
            this.gbxDetalhamento.Controls.Add(this.label5);
            this.gbxDetalhamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalhamento.Location = new System.Drawing.Point(16, 287);
            this.gbxDetalhamento.Name = "gbxDetalhamento";
            this.gbxDetalhamento.Size = new System.Drawing.Size(714, 226);
            this.gbxDetalhamento.TabIndex = 5;
            this.gbxDetalhamento.TabStop = false;
            this.gbxDetalhamento.Text = "Detalhamento do Pedido";
            this.gbxDetalhamento.Enter += new System.EventHandler(this.gbxDetalhamento_Enter);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(626, 46);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(70, 158);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // lblQtde
            // 
            this.lblQtde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(522, 46);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(82, 158);
            this.lblQtde.TabIndex = 6;
            this.lblQtde.Text = "Quantidade";
            this.lblQtde.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(62, 46);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(454, 158);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblItem
            // 
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(7, 46);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(34, 158);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(641, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(522, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orçamento Número";
            // 
            // lblNOrcamento
            // 
            this.lblNOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOrcamento.Location = new System.Drawing.Point(416, 76);
            this.lblNOrcamento.Name = "lblNOrcamento";
            this.lblNOrcamento.Size = new System.Drawing.Size(204, 23);
            this.lblNOrcamento.TabIndex = 2;
            this.lblNOrcamento.Text = "label2";
            this.lblNOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCliente.Location = new System.Drawing.Point(12, 195);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(51, 20);
            this.lblDadosCliente.TabIndex = 1;
            this.lblDadosCliente.Text = "label2";
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 144);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.printPreviewDialog1_FormClosed);
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 742);
            this.ControlBox = false;
            this.Controls.Add(this.pnlImprimir);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido Nº";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlImprimir.ResumeLayout(false);
            this.pnlImprimir.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbxDetalhamento.ResumeLayout(false);
            this.gbxDetalhamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbxDetalhamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNOrcamento;
        private System.Windows.Forms.Label lblDadosCliente;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblItem;
    }
}