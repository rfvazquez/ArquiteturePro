namespace ArchitecturePro.Componentes
{
    partial class ControleFluxoCaixa
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(0, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(80, 43);
            this.lblDia.TabIndex = 0;
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDia.DoubleClick += new System.EventHandler(this.lblDia_DoubleClick);
            // 
            // lblSaldo
            // 
            this.lblSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(0, 43);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(80, 22);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSaldo.DoubleClick += new System.EventHandler(this.lblSaldo_DoubleClick);
            // 
            // ControleFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblDia);
            this.Name = "ControleFluxoCaixa";
            this.Size = new System.Drawing.Size(80, 80);
            this.Load += new System.EventHandler(this.ControleFluxoCaixa_Load);
            this.DoubleClick += new System.EventHandler(this.ControleFluxoCaixa_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblSaldo;
    }
}
