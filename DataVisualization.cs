using System.Drawing;

namespace System.Windows.Forms
{
    internal class DataVisualization
    {
        internal class Charting
        {
            internal class ChartArea
            {
                public string Name { get; internal set; }
            }

            internal class Series
            {
                internal object ChartType;

                public string ChartArea { get; internal set; }
                public string Legend { get; internal set; }
                public string Name { get; internal set; }
            }

            internal class Title
            {
                public string Name { get; internal set; }
                public string Text { get; internal set; }
            }

            internal class Legend
            {
            }

            internal class Chart
            {
                public Chart()
                {
                }
                public object ChartAreas { get; internal set; }
                public Point Location { get; internal set; }
                public string Name { get; internal set; }
                public object Series { get; internal set; }
                public Size Size { get; internal set; }
                public int TabIndex { get; internal set; }
                public string Text { get; internal set; }
                public object Titles { get; internal set; }
            }
        }
    }
}