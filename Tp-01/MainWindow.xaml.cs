using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace Tp_01
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn_close_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        private void Btn_valid_Click(object sender, RoutedEventArgs e)
        {
            Rslt_list.Items.Clear();
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Srch_bar.Text);
                Rslt_list.Items.Add(String.Format("Machine : {0}\nAdresse IP :", host.HostName));
                foreach (IPAddress addr in host.AddressList)
                {
                    Rslt_list.Items.Add(addr);
                }
            }
            catch (ArgumentException)
            {
                Rslt_list.Items.Add("Adresse invalide.");
            }
            catch (SocketException)
            {
                Rslt_list.Items.Add("Impossible de résoudre l'adresse.");
            }
            catch (Exception)
            {
                Rslt_list.Items.Add("Une erreur est survenue.");
            }
        }
    }
}
