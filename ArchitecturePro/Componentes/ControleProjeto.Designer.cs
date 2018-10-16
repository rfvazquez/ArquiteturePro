namespace ArchitecturePro.Componentes
{
    partial class ControleProjeto
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pgbTempoProjeto = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgbFaseProjeto = new System.Windows.Forms.ProgressBar();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblValorGasto = new System.Windows.Forms.Label();
            this.lblValorNota = new System.Windows.Forms.Label();
            this.lblDataProximaEntrega = new System.Windows.Forms.Label();
            this.lblProximaFase = new System.Windows.Forms.Label();
            this.lblProximoPagamento = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.chartCentroCusto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCentroCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjeto
            // 
            this.lblProjeto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjeto.Location = new System.Drawing.Point(0, 0);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(697, 32);
            this.lblProjeto.TabIndex = 0;
            this.lblProjeto.Text = "Projeto 123456";
            this.lblProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProjeto.Click += new System.EventHandler(this.lblProjeto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pgbTempoProjeto);
            this.groupBox1.Location = new System.Drawing.Point(252, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 41);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempo de Projeto";
            // 
            // pgbTempoProjeto
            // 
            this.pgbTempoProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbTempoProjeto.Location = new System.Drawing.Point(3, 16);
            this.pgbTempoProjeto.Name = "pgbTempoProjeto";
            this.pgbTempoProjeto.Size = new System.Drawing.Size(436, 22);
            this.pgbTempoProjeto.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgbFaseProjeto);
            this.groupBox2.Location = new System.Drawing.Point(252, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 41);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fase do Projeto";
            // 
            // pgbFaseProjeto
            // 
            this.pgbFaseProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbFaseProjeto.Location = new System.Drawing.Point(3, 16);
            this.pgbFaseProjeto.Name = "pgbFaseProjeto";
            this.pgbFaseProjeto.Size = new System.Drawing.Size(433, 22);
            this.pgbFaseProjeto.TabIndex = 0;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(249, 137);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(157, 13);
            this.lblDataInicio.TabIndex = 3;
            this.lblDataInicio.Text = "Data Inicio projeto: 01/01/2017";
            // 
            // lblValorGasto
            // 
            this.lblValorGasto.AutoSize = true;
            this.lblValorGasto.Location = new System.Drawing.Point(249, 160);
            this.lblValorGasto.Name = "lblValorGasto";
            this.lblValorGasto.Size = new System.Drawing.Size(166, 13);
            this.lblValorGasto.TabIndex = 4;
            this.lblValorGasto.Text = "Valor Gasto no Projeto: R$000,00";
            // 
            // lblValorNota
            // 
            this.lblValorNota.AutoSize = true;
            this.lblValorNota.Location = new System.Drawing.Point(249, 184);
            this.lblValorNota.Name = "lblValorNota";
            this.lblValorNota.Size = new System.Drawing.Size(152, 13);
            this.lblValorNota.TabIndex = 5;
            this.lblValorNota.Text = "Valor Nota Projeto: R$0000,00";
            // 
            // lblDataProximaEntrega
            // 
            this.lblDataProximaEntrega.AutoSize = true;
            this.lblDataProximaEntrega.Location = new System.Drawing.Point(446, 137);
            this.lblDataProximaEntrega.Name = "lblDataProximaEntrega";
            this.lblDataProximaEntrega.Size = new System.Drawing.Size(174, 13);
            this.lblDataProximaEntrega.TabIndex = 6;
            this.lblDataProximaEntrega.Text = "Data Próxima Entrega: 01/01/2017";
            // 
            // lblProximaFase
            // 
            this.lblProximaFase.AutoSize = true;
            this.lblProximaFase.Location = new System.Drawing.Point(446, 160);
            this.lblProximaFase.Name = "lblProximaFase";
            this.lblProximaFase.Size = new System.Drawing.Size(245, 13);
            this.lblProximaFase.TabIndex = 7;
            this.lblProximaFase.Text = "Fase Atual: aa ascascasc csaiji ckc askjcsa kc ka";
            // 
            // lblProximoPagamento
            // 
            this.lblProximoPagamento.AutoSize = true;
            this.lblProximoPagamento.Location = new System.Drawing.Point(446, 184);
            this.lblProximoPagamento.Name = "lblProximoPagamento";
            this.lblProximoPagamento.Size = new System.Drawing.Size(230, 13);
            this.lblProximoPagamento.TabIndex = 8;
            this.lblProximoPagamento.Text = "Próximo Pagamento: 01/01/2017 - R$ 0000,00";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(3, 114);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 9;
            this.lblCliente.Text = "Cliente:";
            // 
            // chartCentroCusto
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCentroCusto.ChartAreas.Add(chartArea1);
            this.chartCentroCusto.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chartCentroCusto.Legends.Add(legend1);
            this.chartCentroCusto.Location = new System.Drawing.Point(0, 32);
            this.chartCentroCusto.Name = "chartCentroCusto";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
            series1.Legend = "Legend1";
            series1.Name = "SerieGastos";
            this.chartCentroCusto.Series.Add(series1);
            this.chartCentroCusto.Size = new System.Drawing.Size(243, 175);
            this.chartCentroCusto.TabIndex = 10;
            this.chartCentroCusto.Text = "Gastos por Centro de Custo";
            title1.Name = "Title1";
            title1.Text = "Gastos por Centro de Custo";
            this.chartCentroCusto.Titles.Add(title1);
            // 
            // ControleProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.chartCentroCusto);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblProximoPagamento);
            this.Controls.Add(this.lblProximaFase);
            this.Controls.Add(this.lblDataProximaEntrega);
            this.Controls.Add(this.lblValorNota);
            this.Controls.Add(this.lblValorGasto);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProjeto);
            this.Name = "ControleProjeto";
            this.Size = new System.Drawing.Size(697, 207);
            this.Load += new System.EventHandler(this.ControleProjeto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCentroCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pgbTempoProjeto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pgbFaseProjeto;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblValorGasto;
        private System.Windows.Forms.Label lblValorNota;
        private System.Windows.Forms.Label lblDataProximaEntrega;
        private System.Windows.Forms.Label lblProximaFase;
        private System.Windows.Forms.Label lblProximoPagamento;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCentroCusto;
    }
}
