namespace ArchitecturePro.Forms.FormUtil
{
    partial class frmBuscaItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAceitar = new System.Windows.Forms.Button();
            this.grdItem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnAceitar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 70);
            this.panel1.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(791, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 70);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnAceitar
            // 
            this.btnAceitar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceitar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceitar.Image")));
            this.btnAceitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceitar.Location = new System.Drawing.Point(866, 0);
            this.btnAceitar.Name = "btnAceitar";
            this.btnAceitar.Size = new System.Drawing.Size(75, 70);
            this.btnAceitar.TabIndex = 0;
            this.btnAceitar.Text = "&Aceitar";
            this.btnAceitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceitar.UseVisualStyleBackColor = true;
            this.btnAceitar.Click += new System.EventHandler(this.btnAceitar_Click);
            // 
            // grdItem
            // 
            this.grdItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdItem.Location = new System.Drawing.Point(0, 0);
            this.grdItem.MainView = this.gridView1;
            this.grdItem.Name = "grdItem";
            this.grdItem.Size = new System.Drawing.Size(941, 200);
            this.grdItem.TabIndex = 9;
            this.grdItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdItem;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmBuscaItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 270);
            this.ControlBox = false;
            this.Controls.Add(this.grdItem);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuscaItem";
            this.Text = "Busca Item";
            this.Load += new System.EventHandler(this.frmBuscaItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private DevExpress.XtraGrid.GridControl grdItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnAceitar;
    }
}