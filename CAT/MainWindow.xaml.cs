using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CAT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartLongOperation(object sender, RoutedEventArgs e)
        {
            Thread backgroundThread = new Thread(() =>
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    double result = Math.Sqrt(i);
                }
            });

            backgroundThread.Start();
        }
    }
}
