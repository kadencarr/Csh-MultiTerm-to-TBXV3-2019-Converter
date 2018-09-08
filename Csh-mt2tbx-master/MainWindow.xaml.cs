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

namespace Csh_mt2tbx
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string mappingFn = "";
        public string xmlFn = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mappingUpload_Click(object sender, RoutedEventArgs e)
        {
            mappingFn = Methods.readFile("Mapping");
        }

        private void xmlUpload_Click(object sender, RoutedEventArgs e)
        {
            xmlFn = Methods.readFile("XML");
        }

        private void convert_Click(object sender, RoutedEventArgs e)
        {
            if (Core.IsChecked == true)
            {
                Methods m = new Methods();
                m.deserializeFile(mappingFn, xmlFn, "TBX-Core");
            }
            else if (Min.IsChecked == true)
            {
                Methods m = new Methods();
                m.deserializeFile(mappingFn, xmlFn, "TBX-Core");
            }
            else if (Basic.IsChecked == true)
            {
                Methods m = new Methods();
                m.deserializeFile(mappingFn, xmlFn, "TBX-Core");
            }
            this.Close();
        }
    }
}
