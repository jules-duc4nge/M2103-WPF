using System;
using System.Collections.Generic;
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
    public partial class MainWindow : Window
    {
        List<Point> coordinates = new List<Point>(2);
        
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Cvs_Draw_Click(object sender, MouseButtonEventArgs e)
        {
            DebugLabel.Content = coordinates.Count;
            if (true)
            {
                coordinates.Add(Mouse.GetPosition(Cvs_Draw));
                DebugLabel.Content = coordinates.Count;
            } else
            {
                coordinates.Add(Mouse.GetPosition(Cvs_Draw));
                Line line = new Line();
                line.Stroke = Brushes.Purple;
                line.X1 = coordinates[0].X;
                line.Y1 = coordinates[0].Y;
                line.X2 = coordinates[1].X;
                line.Y2 = coordinates[1].Y;
                Cvs_Draw.Children.Add(line);
                coordinates.RemoveAt(0);
            DebugLabel.Content = Cvs_Draw.Children.Count;
            }
        }
    }
}
