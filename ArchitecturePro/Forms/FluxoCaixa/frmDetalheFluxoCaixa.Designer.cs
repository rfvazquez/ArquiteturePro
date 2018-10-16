namespace ArchitecturePro.Forms.FluxoCaixa
{
    partial class frmDetalheFluxoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalheFluxoCaixa));
            this.lblMes = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grdDetalheFluxo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalheFluxo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(0, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(480, 31);
            this.lblMes.TabIndex = 10;
            this.lblMes.Text = "label1";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.button1);
            this.pnlBotoes.Controls.Add(this.btnAvancar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);
            this.pnlBotoes.Controls.Add(this.btnAtualizar);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 347);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(480, 77);
            this.pnlBotoes.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(255, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 77);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Lançar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAvancar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvancar.Image")));
            this.btnAvancar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAvancar.Location = new System.Drawing.Point(75, 0);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 77);
            this.btnAvancar.TabIndex = 7;
            this.btnAvancar.Text = "Ava&nçar";
            this.btnAvancar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.Location = new System.Drawing.Point(0, 0);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 77);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAtualizar.Location = new System.Drawing.Point(330, 0);
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
            this.btnSair.Location = new System.Drawing.Point(405, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // grdDetalheFluxo
            // 
            this.grdDetalheFluxo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalheFluxo.Location = new System.Drawing.Point(0, 31);
            this.grdDetalheFluxo.MainView = this.gridView1;
            this.grdDetalheFluxo.Name = "grdDetalheFluxo";
            this.grdDetalheFluxo.Size = new System.Drawing.Size(480, 316);
            this.grdDetalheFluxo.TabIndex = 11;
            this.grdDetalheFluxo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdDetalheFluxo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmDetalheFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 424);
            this.ControlBox = false;
            this.Controls.Add(this.grdDetalheFluxo);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDetalheFluxoCaixa";
            this.Text = "Detalhe Fluxo de Caixa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDetalheFluxoCaixa_FormClosed);
            this.Load += new System.EventHandler(this.frmDetalheFluxoCaixa_Load);
            this.pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalheFluxo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private DevExpress.XtraGrid.GridControl grdDetalheFluxo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
    }
}