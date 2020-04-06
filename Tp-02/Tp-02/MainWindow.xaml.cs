using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tp_02
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class DrawingSurface : Canvas
    {
        public Point last_touch { get; set; }
        public SolidColorBrush current_color = Brushes.White;

        public DrawingSurface()
        {
            this.last_touch = new Point { X = double.NaN, Y = double.NaN };
        }
        public void Reset()
        {
            this.Children.Clear();
            last_touch = new Point { X = double.NaN, Y = double.NaN };
        }
        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            if (!double.IsNaN(this.last_touch.X) && !double.IsNaN(this.last_touch.Y))
            {
                this.Add_Stroke();
            }
            last_touch = e.GetPosition(this);
        }
        public void Add_Stroke()
        {
            Line line = new Line
            {
                X1 = last_touch.X,
                Y1 = last_touch.Y,
                X2 = Mouse.GetPosition(this).X,
                Y2 = Mouse.GetPosition(this).Y,
                Stroke = current_color
            };
            this.Children.Add(line);
        }
    }
    public partial class MainWindow : Window
    {
        List<SolidColorBrush> colors = 
            new List<SolidColorBrush> {Brushes.Orange, Brushes.Green, Brushes.Blue, Brushes.IndianRed};
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn_clear_Click(object sender, RoutedEventArgs e)
        {
            Cvs_Draw.Reset();
        }
        private void Cbb_Colors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cvs_Draw.current_color = colors[Cbb_Colors.SelectedIndex];
        }
    }
}
