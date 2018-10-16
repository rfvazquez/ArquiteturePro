namespace ArchitecturePro.Forms.FluxoCaixa
{
    partial class frmFluxoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoCaixa));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 40D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.pnlGeral = new System.Windows.Forms.Panel();
            this.pnlDomingo = new System.Windows.Forms.Panel();
            this.pnlSabado = new System.Windows.Forms.Panel();
            this.pnlSexta = new System.Windows.Forms.Panel();
            this.pnlQuinta = new System.Windows.Forms.Panel();
            this.pnlQuarta = new System.Windows.Forms.Panel();
            this.pnlTerca = new System.Windows.Forms.Panel();
            this.pnlSegunda = new System.Windows.Forms.Panel();
            this.pnlGraficoControle = new System.Windows.Forms.Panel();
            this.chartGanhos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCentroCusto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlBotoes.SuspendLayout();
            this.pnlGeral.SuspendLayout();
            this.pnlGraficoControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGanhos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCentroCusto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnAvancar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);
            this.pnlBotoes.Controls.Add(this.btnAtualizar);
            this.pnlBotoes.Controls.Add(this.btnSair);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 429);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(836, 77);
            this.pnlBotoes.TabIndex = 7;
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
            this.btnAtualizar.Location = new System.Drawing.Point(686, 0);
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
            this.btnSair.Location = new System.Drawing.Point(761, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 77);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMes
            // 
            this.lblMes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(0, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(836, 57);
            this.lblMes.TabIndex = 8;
            this.lblMes.Text = "label1";
            this.lblMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGeral
            // 
            this.pnlGeral.AutoScroll = true;
            this.pnlGeral.AutoSize = true;
            this.pnlGeral.Controls.Add(this.pnlDomingo);
            this.pnlGeral.Controls.Add(this.pnlSabado);
            this.pnlGeral.Controls.Add(this.pnlSexta);
            this.pnlGeral.Controls.Add(this.pnlQuinta);
            this.pnlGeral.Controls.Add(this.pnlQuarta);
            this.pnlGeral.Controls.Add(this.pnlTerca);
            this.pnlGeral.Controls.Add(this.pnlSegunda);
            this.pnlGeral.Controls.Add(this.pnlGraficoControle);
            this.pnlGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeral.Location = new System.Drawing.Point(0, 57);
            this.pnlGeral.Name = "pnlGeral";
            this.pnlGeral.Size = new System.Drawing.Size(836, 372);
            this.pnlGeral.TabIndex = 9;
            this.pnlGeral.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGeral_Paint);
            // 
            // pnlDomingo
            // 
            this.pnlDomingo.AutoSize = true;
            this.pnlDomingo.Location = new System.Drawing.Point(683, 291);
            this.pnlDomingo.Name = "pnlDomingo";
            this.pnlDomingo.Size = new System.Drawing.Size(112, 443);
            this.pnlDomingo.TabIndex = 31;
            this.pnlDomingo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDomingo_Paint);
            // 
            // pnlSabado
            // 
            this.pnlSabado.AutoSize = true;
            this.pnlSabado.Location = new System.Drawing.Point(570, 291);
            this.pnlSabado.Name = "pnlSabado";
            this.pnlSabado.Size = new System.Drawing.Size(112, 443);
            this.pnlSabado.TabIndex = 29;
            // 
            // pnlSexta
            // 
            this.pnlSexta.AutoSize = true;
            this.pnlSexta.Location = new System.Drawing.Point(457, 291);
            this.pnlSexta.Name = "pnlSexta";
            this.pnlSexta.Size = new System.Drawing.Size(112, 443);
            this.pnlSexta.TabIndex = 28;
            // 
            // pnlQuinta
            // 
            this.pnlQuinta.AutoSize = true;
            this.pnlQuinta.Location = new System.Drawing.Point(344, 291);
            this.pnlQuinta.Name = "pnlQuinta";
            this.pnlQuinta.Size = new System.Drawing.Size(112, 443);
            this.pnlQuinta.TabIndex = 27;
            // 
            // pnlQuarta
            // 
            this.pnlQuarta.AutoSize = true;
            this.pnlQuarta.Location = new System.Drawing.Point(231, 291);
            this.pnlQuarta.Name = "pnlQuarta";
            this.pnlQuarta.Size = new System.Drawing.Size(112, 443);
            this.pnlQuarta.TabIndex = 26;
            // 
            // pnlTerca
            // 
            this.pnlTerca.AutoSize = true;
            this.pnlTerca.Location = new System.Drawing.Point(118, 291);
            this.pnlTerca.Name = "pnlTerca";
            this.pnlTerca.Size = new System.Drawing.Size(112, 443);
            this.pnlTerca.TabIndex = 25;
            // 
            // pnlSegunda
            // 
            this.pnlSegunda.AutoSize = true;
            this.pnlSegunda.Location = new System.Drawing.Point(5, 291);
            this.pnlSegunda.Name = "pnlSegunda";
            this.pnlSegunda.Size = new System.Drawing.Size(112, 443);
            this.pnlSegunda.TabIndex = 24;
            // 
            // pnlGraficoControle
            // 
            this.pnlGraficoControle.Controls.Add(this.chartGanhos);
            this.pnlGraficoControle.Controls.Add(this.chartCentroCusto);
            this.pnlGraficoControle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGraficoControle.Location = new System.Drawing.Point(0, 0);
            this.pnlGraficoControle.Name = "pnlGraficoControle";
            this.pnlGraficoControle.Size = new System.Drawing.Size(819, 285);
            this.pnlGraficoControle.TabIndex = 23;
            // 
            // chartGanhos
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGanhos.ChartAreas.Add(chartArea1);
            this.chartGanhos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartGanhos.Legends.Add(legend1);
            this.chartGanhos.Location = new System.Drawing.Point(356, 0);
            this.chartGanhos.Name = "chartGanhos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Total de Gastos";
            series1.Name = "SerieGastos";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Total de Ganhos";
            series2.Name = "SeriesGanhos";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.LegendText = "Total em Caixa";
            series3.Name = "SerieTotalCaixa";
            this.chartGanhos.Series.Add(series1);
            this.chartGanhos.Series.Add(series2);
            this.chartGanhos.Series.Add(series3);
            this.chartGanhos.Size = new System.Drawing.Size(463, 285);
            this.chartGanhos.TabIndex = 2;
            title1.Name = "Title1";
            title1.Text = "Comparativo de Valores";
            this.chartGanhos.Titles.Add(title1);
            // 
            // chartCentroCusto
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCentroCusto.ChartAreas.Add(chartArea2);
            this.chartCentroCusto.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.chartCentroCusto.Legends.Add(legend2);
            this.chartCentroCusto.Location = new System.Drawing.Point(0, 0);
            this.chartCentroCusto.Name = "chartCentroCusto";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
            series4.Legend = "Legend1";
            series4.Name = "SerieGastos";
            this.chartCentroCusto.Series.Add(series4);
            this.chartCentroCusto.Size = new System.Drawing.Size(356, 285);
            this.chartCentroCusto.TabIndex = 1;
            this.chartCentroCusto.Text = "Gastos por Centro de Custo";
            title2.Name = "Title1";
            title2.Text = "Gastos por Centro de Custo";
            this.chartCentroCusto.Titles.Add(title2);
            // 
            // frmFluxoCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 506);
            this.Controls.Add(this.pnlGeral);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFluxoCaixa";
            this.Text = "Fluxo de Caixa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFluxoCaixa_FormClosed);
            this.Load += new System.EventHandler(this.frmFluxoCaixa_Load);
            this.ResizeEnd += new System.EventHandler(this.frmFluxoCaixa_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmFluxoCaixa_Resize);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlGeral.ResumeLayout(false);
            this.pnlGeral.PerformLayout();
            this.pnlGraficoControle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGanhos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCentroCusto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Panel pnlGeral;
        private System.Windows.Forms.Panel pnlGraficoControle;
        private System.Windows.Forms.Panel pnlDomingo;
        private System.Windows.Forms.Panel pnlSabado;
        private System.Windows.Forms.Panel pnlSexta;
        private System.Windows.Forms.Panel pnlQuinta;
        private System.Windows.Forms.Panel pnlQuarta;
        private System.Windows.Forms.Panel pnlTerca;
        private System.Windows.Forms.Panel pnlSegunda;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCentroCusto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGanhos;
    }
}