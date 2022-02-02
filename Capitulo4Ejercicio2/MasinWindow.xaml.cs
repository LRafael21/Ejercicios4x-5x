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

namespace Capitulo4Ejercicio2
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

        public void ElevarButton_Click(object sender, RoutedEventArgs e)
        {

            Validar();
            int num = Convert.ToInt32(NumeroTextBox.Text);
            double cuadrado = Math.Pow(num, 2);
            MessageBox.Show($"{num.ToString()} elevado al cuadrado es {cuadrado.ToString()}");

        }

        private bool Validar()
        {

            bool esValido = true;

            if (NumeroTextBox.Text.Length <= 0)
            {
                esValido = false;
                MessageBox.Show("Debe Digitar un numero", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }
    }
}
