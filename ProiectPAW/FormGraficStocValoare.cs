using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectPAW
{
    public partial class FormGraficStocValoare : Form
    {
        private List<Produs> produse;

        public FormGraficStocValoare(List<Produs> listaProduse)
        {
            InitializeComponent();
            produse = listaProduse;
            GenereazaGrafic();
        }

        private void GenereazaGrafic()
        {
            chartValoareStoc.Series.Clear();
            chartValoareStoc.ChartAreas.Clear();

            ChartArea zona = new ChartArea("zona1");
            chartValoareStoc.ChartAreas.Add(zona);

            Series serie = new Series("Valoare Stoc");
            serie.ChartType = SeriesChartType.Bar;
            serie.IsValueShownAsLabel = true;

            var top5 = produse
                .OrderByDescending(p => p.CantitateStoc * p.PretUnitar)
                .Take(5);

            foreach (var produs in top5)
            {
                double valoare = produs.CantitateStoc * produs.PretUnitar;
                serie.Points.AddXY(produs.Denumire, valoare);
            }

            chartValoareStoc.Series.Add(serie);
        }
    }
}
