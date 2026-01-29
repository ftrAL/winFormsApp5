using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormGrafik : Form
    {
        private List<int> nilaiMahasiswa = new List<int>()
        {
            70, 85, 90, 60, 75
        };

        private Panel chartPanel;
        private Button btnPrint;

        private PrintDocument printDocument;

        public FormGrafik()
        {
            InitializeComponent();
        }

        private void InitGrafik()
        {
            chartPanel = new Panel();
            chartPanel.Dock = DockStyle.Top;
            chartPanel.Height = 300;
            chartPanel.BackColor = Color.White;
            chartPanel.Paint += ChartPanel_Paint;

            Controls.Add(chartPanel);
        }

        // Custom simple bar-chart rendering to avoid dependency on System.Windows.Forms.DataVisualization
        private void ChartPanel_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(chartPanel.BackColor);

            using var titleFont = new Font("Arial", 14, FontStyle.Bold);
            using var textFont = new Font("Arial", 10);
            using var barBrush = new SolidBrush(Color.SteelBlue);
            using var pen = new Pen(Color.Black);

            // Title
            string title = "Laporan Nilai Quiz";
            var titleSize = g.MeasureString(title, titleFont);
            g.DrawString(title, titleFont, Brushes.Black,
                (chartPanel.ClientSize.Width - titleSize.Width) / 2, 8);

            int paddingLeft = 40;
            int paddingTop = (int)titleSize.Height + 16;
            int paddingBottom = 30;
            int availableWidth = chartPanel.ClientSize.Width - paddingLeft - 20;
            int availableHeight = chartPanel.ClientSize.Height - paddingTop - paddingBottom;
            if (availableWidth <= 0 || availableHeight <= 0 || nilaiMahasiswa.Count == 0)
                return;

            int count = nilaiMahasiswa.Count;
            int spacing = 10;
            int barWidth = Math.Max(8, (availableWidth - spacing * (count - 1)) / count);

            int maxVal = Math.Max(100, nilaiMahasiswa.Max());
            float scale = availableHeight / (float)maxVal;

            int startX = paddingLeft;

            for (int i = 0; i < count; i++)
            {
                int val = nilaiMahasiswa[i];
                int barHeight = (int)(val * scale);
                int x = startX + i * (barWidth + spacing);
                int y = paddingTop + (availableHeight - barHeight);

                var rect = new Rectangle(x, y, barWidth, barHeight);
                g.FillRectangle(barBrush, rect);
                g.DrawRectangle(pen, rect);

                // value above bar
                string valText = val.ToString();
                var valSize = g.MeasureString(valText, textFont);
                g.DrawString(valText, textFont, Brushes.Black,
                    x + (barWidth - valSize.Width) / 2,
                    y - valSize.Height - 2);

                // label below bar
                string label = $"Mhs {i + 1}";
                var labelSize = g.MeasureString(label, textFont);
                g.DrawString(label, textFont, Brushes.Black,
                    x + (barWidth - labelSize.Width) / 2,
                    paddingTop + availableHeight + 4);
            }

            // axis line
            g.DrawLine(pen, paddingLeft - 8, paddingTop + availableHeight + 2,
                paddingLeft + availableWidth, paddingTop + availableHeight + 2);
        }

        private void InitPrint()
        {
            btnPrint = new Button();
            btnPrint.Text = "Print Hasil";
            btnPrint.Dock = DockStyle.Bottom;
            btnPrint.Height = 40;
            btnPrint.Click += BtnPrint_Click;

            Controls.Add(btnPrint);

            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void BtnPrint_Click(object? sender, EventArgs e)
        {
            using var preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            preview.ShowDialog();
        }

        // PRINT + ALIGNMENT
        private void PrintDocument_PrintPage(object? sender, PrintPageEventArgs e)
        {
            using Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            using Font textFont = new Font("Arial", 11);

            float centerX = e.PageBounds.Width / 2f;

            StringFormat center = new StringFormat
            {
                Alignment = StringAlignment.Center
            };

            e.Graphics.DrawString(
                "Laporan Nilai Quiz",
                titleFont,
                Brushes.Black,
                centerX,
                80,
                center
            );

            float y = 150f;

            for (int i = 0; i < nilaiMahasiswa.Count; i++)
            {
                e.Graphics.DrawString(
                    $"Mahasiswa {i + 1} : {nilaiMahasiswa[i]}",
                    textFont,
                    Brushes.Black,
                    120f,
                    y
                );

                y += 30f;
            }
        }

        // Add this method to handle the Load event and initialize the chart and print button.
        private void FormGrafik_Load(object? sender, EventArgs e)
        {
            InitGrafik();
            InitPrint();
        }
    }
}
