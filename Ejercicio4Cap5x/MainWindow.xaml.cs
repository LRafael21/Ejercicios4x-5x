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

namespace Ejercicio4Cap5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void EjecutarButton_Click(object sender, RoutedEventArgs e){
            
          do
            {
            verificar(Convert.ToInt32(NumeroTextBox.Text));

            } while (Convert.ToInt32(NumeroTextBox.Text) < 0);

            factorial(Convert.ToInt32(NumeroTextBox.Text));

        }

        static void factorial(double n)
        {
            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            MessageBox.Show($"El Factorial de {n} es: {fact}");

        }

        static void verificar(int n)
        {
            if (n < 0)
            {
                MessageBox.Show("No existe el factorial de un número negativo");
            }

        }

    }
}
