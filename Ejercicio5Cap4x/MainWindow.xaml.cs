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

namespace Ejercio5Cap4
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



        private void EjecutarButton_Click(object sender, RoutedEventArgs e)
        {

            int[] array = new int[7];
            int mayor = 0;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = int.Parse(Numero1.Text);
                array[i] = int.Parse(Numero2.Text);
                array[i] = int.Parse(Numero3.Text);
                array[i] = int.Parse(Numero4.Text);
                array[i] = int.Parse(Numero5.Text);
                array[i] = int.Parse(Numero6.Text);
                array[i] = int.Parse(Numero7.Text);
                if (i == 0)
                {

                    mayor = array[i];

                }
                
                else
                {
                    if (array[i] > mayor)
                    {

                        mayor = array[i];
                    }
                }

            }
            MessageBox.Show($"El Mayor es {mayor.ToString()}");


        }
    }
}




