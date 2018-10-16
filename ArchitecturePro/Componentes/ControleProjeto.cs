using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ArchitecturePro.DataBase;

namespace ArchitecturePro.Componentes
{
    public partial class ControleProjeto : UserControl
    {
        public tb_projeto prj;
        public ControleProjeto()
        {
            InitializeComponent();
        }

        public void MontaResumoProjeto(tb_projeto projeto)
        {
            prj = projeto;
            try
            {

                var dataInicio = projeto.prj_DataInicio;
                var dataFinalPrevisto = projeto.prj_DataFimPrevista;
                var maxData = (dataFinalPrevisto - dataInicio).Days;
                var diffData = (DateTime.Now - dataInicio).Days;
                try
                {
                    //Montando barra de fase do projeto
                    pgbFaseProjeto.Maximum = projeto.tb_fasesProjeto.Count;
                    pgbFaseProjeto.Minimum = 0;
                    pgbFaseProjeto.Value = projeto.tb_fasesProjeto.Where(x => x.fap_Finalizada).Count();


                    //Montando a Data do projeto
                    pgbTempoProjeto.Maximum = maxData;
                    pgbTempoProjeto.Minimum = 0;
                    pgbTempoProjeto.Value = diffData > maxData ? maxData : diffData;

                }
                catch (Exception) { }
                //Preenchendo as Labels
                lblCliente.Text = String.Format("Cliente: {0}", projeto.tb_cliente.cli_Fantasia);
                lblDataInicio.Text = String.Format("Data Início do Projeto: {0}", dataInicio.ToString("dd/MM/yyyy"));
                lblDataProximaEntrega.Text = String.Format("Data da Próxima entrega do Projeto: {0}",
                        projeto.tb_fasesProjeto.Where(x => x.fap_Finalizada == false).Min(x => x.fap_DataPrevista).Date.ToString("dd/MM/yyyy"));
                lblProjeto.Text = String.Format("Projeto ID {0}", projeto.prj_Id);

                var proximaFase = "";
                try
                {
                    var menorData = projeto.tb_fasesProjeto.Where(
                        x => x.fap_Finalizada == false).Min(x => x.fap_DataPrevista).Date;
                    proximaFase = projeto.tb_fasesProjeto.FirstOrDefault(
                        x => x.fap_Finalizada == false && x.fap_DataPrevista.Date == menorData).tb_fases.fas_Descricao;
                }
                catch (Exception ex)
                {
                    lblProximaFase.Text = ex.Message;
                }

                lblProximaFase.Text = String.Format("Próxima fase do Projeto: {0}", proximaFase);


                lblValorGasto.Text = String.Format("Valor gasto até o momento: R$ {0}",
                    projeto.tb_projetoFluxoCaixa.Where(x => x.pfc_Despesa)
                        .Sum(x => x.tb_fluxoCaixa.flc_Valor)
                        .ToString());

                lblValorNota.Text = String.Format("Valor do Pedido: R$ {0}", projeto.tb_ItemPedido.Sum(x => x.ipo_Valor).ToString());

                var dataPagamento =
                    projeto.tb_projetoFluxoCaixa.Where(x => x.pfc_Despesa == false)
                        .Min(x => x.tb_fluxoCaixa.flc_DataCaixa)
                        .Date;
                var valorPagamento =
                    projeto.tb_projetoFluxoCaixa.FirstOrDefault(
                        x => x.pfc_Despesa == false && x.tb_fluxoCaixa.flc_DataCaixa.Date == dataPagamento).tb_fluxoCaixa.flc_Valor;

                lblProximoPagamento.Text = String.Format("Dados próximo pagamento: {0} - R$ {1}", dataPagamento,
                    valorPagamento);

                List<tb_fluxoCaixa> fluxoCaixa = new List<tb_fluxoCaixa>();
                
                var fluxos = projeto.tb_projetoFluxoCaixa.Where(x => x.pfc_Despesa);
                foreach (var fl in fluxos)
                {
                    fluxoCaixa.Add(fl.tb_fluxoCaixa);
                }
                MontaGraficoGastoCentroCusto(fluxoCaixa);
            }
            catch (Exception)
            {

            }
        }

        private void ControleProjeto_Load(object sender, EventArgs e)
        {

        }

        private void lblProjeto_Click(object sender, EventArgs e)
        {

        }

        private void MontaGraficoGastoCentroCusto(List<tb_fluxoCaixa> fluxoCaixa)
        {
            chartCentroCusto.Series[0].Points.Clear();
            var fluxoCaixaMes =
                fluxoCaixa.Where(x=> x.flc_Entrada == false);
            if (fluxoCaixaMes.Count() > 0)
            {
                chartCentroCusto.Series[0].ChartType = SeriesChartType.Pie;
                var grupos = fluxoCaixaMes.GroupBy(x => x.tb_grupoFinanceiro.grf_Descricao);
                foreach (var grupo in grupos)
                {
                    var valor = Convert.ToDouble(fluxoCaixaMes.Where(x => x.tb_grupoFinanceiro.grf_Descricao == grupo.Key)
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
