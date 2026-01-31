using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WinFormsApp5
{
    public partial class FormGrafik : Form
    {
        public FormGrafik(List<int> daftarNilai)
        {
            InitializeComponent();

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            chart.Titles.Add("Riwayat Nilai Kuis");

            Series s = new Series();
            s.ChartType = SeriesChartType.Column;
            s.IsValueShownAsLabel = true;


            int i = 1;

            foreach (int nilai in daftarNilai)
            {
                s.Points.AddXY("Tes " + i, nilai);
                i++;
            }

            chart.Series.Add(s);
            this.Controls.Add(chart);
        }


    }
}
