using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ArchitecturePro.Componentes;
using ArchitecturePro.ControlView;
using ArchitecturePro.DataBase;
using ArchitecturePro.Util;

namespace ArchitecturePro.Forms.FluxoCaixa
{
    public partial class frmFluxoCaixa : Form
    {
        public DataBaseControler baseControl = new DataBaseControler();
        public int navegaDatas = 0;
        public frmFluxoCaixa()
        {
            InitializeComponent();
            pnlGeral.AutoScroll = true;
            pnlGeral.AutoSize = false;
            pnlGeral.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFluxoCaixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.JanelasAbertas();
        }

        public void RemoveControle(Panel painel)
        {
            painel.Controls.Clear();
        }

        public void CriaLabel(Panel pnl, string texto)
        {
            var label = new Label();
            label.Text = texto;
            label.Dock = DockStyle.Top;
            label.AutoSize = false;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("Arial", 12);
            pnl.Controls.Add(label);

        }

        public void MontaInformacao()
        {
            RemoveControle(pnlSegunda);
            RemoveControle(pnlTerca);
            RemoveControle(pnlQuarta);
            RemoveControle(pnlQuinta);
            RemoveControle(pnlSexta);
            RemoveControle(pnlSabado);
            RemoveControle(pnlDomingo);

            var fluxoCaixa = baseControl.BuscaFluxoCaixa();
            var dataAtual = DateTime.Now.AddMonths(navegaDatas);
            MontaGraficoGastoCentroCusto(fluxoCaixa, dataAtual);
            MontaGraficoGastosVersosGanhos(fluxoCaixa, dataAtual);

            var dias = DateTime.DaysInMonth(dataAtual.Year, dataAtual.Month);
            lblMes.Text = String.Format("Fluxo de Caixa - {0}",dataAtual.ToString("MM/yyyy"));
            var dia = 1;
            while (dia <= dias)
            {
                var data = new DateTime(dataAtual.Year, dataAtual.Month, dias);
                var entrada =
                    fluxoCaixa.Where(x => x.flc_Entrada && x.flc_DataCaixa.Date <= data.Date)
                        .Sum(x => x.flc_Valor);
                var saida = fluxoCaixa.Where(x => x.flc_Entrada == false && x.flc_DataCaixa.Date <= data.Date)
                        .Sum(x => x.flc_Valor);

                Decimal valor = entrada - saida;

                var caixaDia = new ControleFluxoCaixa();
                caixaDia.SetaInformacao(dias.ToString(), "R$ " + valor.ToString(), valor < 0, data);
                caixaDia.Dock = DockStyle.Top;
                caixaDia.principal = this;
                switch (data.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        pnlDomingo.Controls.Add(caixaDia);
                        if (dias == 1)
                        {
                            pnlSegunda.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlTerca.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlQuarta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlQuinta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlSexta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlSabado.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                        }
                        break;
                    case DayOfWeek.Monday:
                        pnlSegunda.Controls.Add(caixaDia);
                        break;
                    case DayOfWeek.Tuesday:
                        pnlTerca.Controls.Add(caixaDia);
                        if (dias == 1)
                        {
                            pnlSegunda.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                        }
                        break;
                    case DayOfWeek.Wednesday:
                        pnlQuarta.Controls.Add(caixaDia);
                        if (dias == 1)
                        {
                            pnlSegunda.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlTerca.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                        }
                        break;
                    case DayOfWeek.Thursday:
                        pnlQuinta.Controls.Add(caixaDia);
                        if (dias == 1)
                        {
                            pnlSegunda.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlTerca.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlQuarta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                        }
                        break;
                    case DayOfWeek.Friday:
                        pnlSexta.Controls.Add(caixaDia);
                        if (dias == 1)
                        {
                            pnlSegunda.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlTerca.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlQuarta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlQuinta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                        }
                        break;
                    case DayOfWeek.Saturday:
                        pnlSabado.Controls.Add(caixaDia);
                        if (dias == 1)
                        {
                            pnlSegunda.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlTerca.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlQuarta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlQuinta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                            pnlSexta.Controls.Add(new ControleFluxoCaixa(DockStyle.Top));
                        }
                        break;
                }
                dias--;
            }
            CriaLabel(pnlSegunda, "Segunda");
            CriaLabel(pnlTerca, "Terça");
            CriaLabel(pnlQuarta, "Quarta");
            CriaLabel(pnlQuinta, "Quinta");
            CriaLabel(pnlSexta, "Sexta");
            CriaLabel(pnlSabado, "Sabado");
            CriaLabel(pnlDomingo, "Domingo");


        }

        private void frmFluxoCaixa_ResizeEnd(object sender, EventArgs e)
        {
        }

        private void frmFluxoCaixa_Load(object sender, EventArgs e)
        {
            MontaInformacao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            navegaDatas--;
            MontaInformacao();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            navegaDatas++;
            MontaInformacao();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var principal = (frmPrincipal)this.MdiParent;
            principal.IniciaAguarde();
            MontaInformacao();
            principal.InterrompeAguarde();
        }

        private void pnlGeral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDomingo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmFluxoCaixa_Resize(object sender, EventArgs e)
        {
            var total = pnlSegunda.Width + pnlTerca.Width + pnlQuarta.Width + pnlQuinta.Width + pnlSexta.Width +
                        pnlSabado.Width + pnlDomingo.Width;
            if (total > this.Width)
            {
                pnlSegunda.Location = new Point(0, pnlSegunda.Location.Y);
            }
            else
            {
                var calcula = (this.Width / 2) - (total / 2);
                pnlSegunda.Location = new Point(calcula, pnlSegunda.Location.Y);

            }

            pnlTerca.Location = new Point(pnlSegunda.Location.X + pnlSegunda.Size.Width, pnlTerca.Location.Y);
            pnlQuarta.Location = new Point(pnlTerca.Location.X + pnlTerca.Size.Width, pnlQuarta.Location.Y);
            pnlQuinta.Location = new Point(pnlQuarta.Location.X + pnlQuarta.Size.Width, pnlQuinta.Location.Y);
            pnlSexta.Location = new Point(pnlQuinta.Location.X + pnlQuinta.Size.Width, pnlSexta.Location.Y);
            pnlSabado.Location = new Point(pnlSexta.Location.X + pnlSexta.Size.Width, pnlSabado.Location.Y);
            pnlDomingo.Location = new Point(pnlSabado.Location.X + pnlSabado.Size.Width, pnlDomingo.Location.Y);

        }



        private void MontaGraficoGastosVersosGanhos(List<tb_fluxoCaixa> fluxoCaixa, DateTime dataCalculo)
        {
            chartGanhos.Series.FirstOrDefault(x => x.Name == "SerieGastos").Points.Clear();
            chartGanhos.Series.FirstOrDefault(x => x.Name == "SeriesGanhos").Points.Clear();
            chartGanhos.Series.FirstOrDefault(x => x.Name == "SerieTotalCaixa").Points.Clear();
            chartGanhos.ChartAreas[0].AxisX.Title = "Dias";
            chartGanhos.ChartAreas[0].AxisX.Interval = 1;
            chartGanhos.ChartAreas[0].AxisY.Title = "Valor";
            chartGanhos.ChartAreas[0].AxisY.Interval = 1000;

            var fluxoCaixaMes =
                fluxoCaixa.Where(
                    x => x.flc_DataCaixa.Month == dataCalculo.Month && x.flc_DataCaixa.Year == dataCalculo.Year);
            var dias = DateTime.DaysInMonth(dataCalculo.Year, dataCalculo.Month);
            var dia = 1;
            while (dias >= dia)
            {
                var data = new DateTime(dataCalculo.Year, dataCalculo.Month, dia);
                var totalGasto =
                    fluxoCaixaMes.Where(x => x.flc_DataCaixa.Date <= data.Date && x.flc_Entrada == false)
                        .Sum(y => y.flc_Valor);
                var totalGanho = fluxoCaixaMes.Where(x => x.flc_DataCaixa.Date <= data.Date && x.flc_Entrada == true)
                        .Sum(y => y.flc_Valor);

                var diff = totalGanho - totalGasto;
                chartGanhos.Series.FirstOrDefault(x => x.Name == "SerieGastos").Points.Add(HelperChart.CriaPontoGraficoLinha(data.Day, Convert.ToDouble(totalGasto)));
                chartGanhos.Series.FirstOrDefault(x => x.Name == "SeriesGanhos").Points.Add(HelperChart.CriaPontoGraficoLinha(data.Day, Convert.ToDouble(totalGanho)));
                chartGanhos.Series.FirstOrDefault(x => x.Name == "SerieTotalCaixa").Points.Add(HelperChart.CriaPontoGraficoLinha(data.Day, Convert.ToDouble(diff)));
                dia++;
            }
        }


        private void MontaGraficoGastoCentroCusto(List<tb_fluxoCaixa> fluxoCaixa, DateTime dataCalculo)
        {
            chartCentroCusto.Series[0].Points.Clear();
            var fluxoCaixaMes =
                fluxoCaixa.Where(
                    x => x.flc_DataCaixa.Month == dataCalculo.Month && x.flc_DataCaixa.Year == dataCalculo.Year && x.flc_Entrada == false);
            if (fluxoCaixaMes.Count() > 0)
            {
                chartCentroCusto.Series[0].ChartType = SeriesChartType.Pie;
                var grupos = fluxoCaixaMes.GroupBy(x => x.tb_grupoFinanceiro.grf_Descricao);
                foreach (var grupo in grupos)
                {
                 var valor= Convert.ToDouble(fluxoCaixaMes.Where(x => x.tb_grupoFinanceiro.grf_Descricao == grupo.Key)
                            .Sum(y => y.flc_Valor));

                    var ponto = new DataPoint();
                    ponto.Label = String.Format("{0}{1}", grupo.Key, "#VAL{C}");
                    ponto.YValues = new double[] { Convert.ToDouble(valor) }; ;
                    ponto.SetCustomProperty("PieLabelStyle", "Disabled");
                    ponto.IsVisibleInLegend = true;
                    ponto.IsValueShownAsLabel = true;
                    chartCentroCusto.Series[0].Points.Add(ponto);
                }
            }

        }
    }
}
