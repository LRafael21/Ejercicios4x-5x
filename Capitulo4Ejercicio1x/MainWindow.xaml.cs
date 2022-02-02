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

namespace _Capitulo4Ejercicio1
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

        public void CalcularButton_Click(object sender, RoutedEventArgs e)
        {

            Validar();

            for (int i = 1; i <= 10; i++)
            {
                int Resultado = Convert.ToInt32(NumeroTextBox.Text) * i;
                MessageBox.Show($"El Resultado de la tabla es {Resultado.ToString()}");

            }
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

