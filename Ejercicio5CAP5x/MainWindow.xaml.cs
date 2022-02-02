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

namespace Ejercicio5Cap5
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

        public void EjecutarButton_Click(object sender, RoutedEventArgs e)
        {


            NumALetras();


        }

        public  void NumALetras()
        {
         

            switch (Convert.ToInt32(NumeroTextBox.Text))
            {
                case 1:
                    MessageBox.Show("UNO");
                    break;

                case 2:

                    MessageBox.Show("DOS");
                    break;

                case 3:
                    MessageBox.Show("TRES");
                    break;

                case 4:
                    MessageBox.Show("CUATRO");
                    break;

                case 5:
                    MessageBox.Show("CINCO");
                    break;

                case 6:
                    MessageBox.Show("SEIS");
                    break;

                case 7:
                    MessageBox.Show("SIETE");
                    break;

                case 8:
                    MessageBox.Show("OCHO");
                    break;

                case 9:
                    MessageBox.Show("NUEVE");
                    break;

                case 10:
                    MessageBox.Show("DIEZ");
                    break;


                default:
                    MessageBox.Show("Intente un numero del (1/10) 😒");
                    break;


            }
        }
    }
}

