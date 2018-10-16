using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArchitecturePro.Util
{
    public class HelperChart
    {
        public static DataPoint CriaPontoGraficoLinha(int valorX, double valorY)
        {
            var ponto = new DataPoint();
            ponto.XValue = valorX;
            ponto.YValues = new double[] { valorY };
            return ponto;
        }
    }
}
