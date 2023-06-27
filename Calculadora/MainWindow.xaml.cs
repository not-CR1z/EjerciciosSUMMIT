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

namespace CALCULADORA
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


        string operador = "";
        double num1;
        double num2;


        public void boton0_Click(object sender, RoutedEventArgs e)
        {

            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "0";
            }

        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "1";
            }
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "2";
            }
        }

        private void boton3_Click(object sender, RoutedEventArgs e)
        {
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "3";
            }
        }

        private void boton4_Click(object sender, RoutedEventArgs e)
        {
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "4";
            }
        }

        private void boton5_Click(object sender, RoutedEventArgs e)
        {
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "5";
            }
        }

        private void boton6_Click(object sender, RoutedEventArgs e)
        {
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "6";
            }
        }

        private void boton7_Click(object sender, RoutedEventArgs e)
        {
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "7";
            }
        }

        private void boton8_Click(object sender, RoutedEventArgs e)
        {
            if (pantalla.Text != null)
            {
                pantalla.Text = pantalla.Text + "8";
            }

        }
        private void boton9_Click(object sender, RoutedEventArgs e)
        {
                if (pantalla.Text != null)
                {
                    pantalla.Text = pantalla.Text + "9";
                }
            }

        

        private void suma_Click(object sender, RoutedEventArgs e)
        {

            operador = "+";
            num1 = int.Parse(pantalla.Text);
            pantalla.Text = $"";

        }

        private void resta_Click(object sender, RoutedEventArgs e)
        {

            operador = "-";
            num1 = int.Parse(pantalla.Text);
            pantalla.Text = "";

        }

        private void multiplicacion_Click(object sender, RoutedEventArgs e)
        {

            operador = "x";
            num1 = int.Parse(pantalla.Text);
            pantalla.Text = "";

        }

        private void division_Click(object sender, RoutedEventArgs e)
        {

            operador = "/";
            num1 = int.Parse(pantalla.Text);
            pantalla.Text = "";

        }

        private void resultado_Click(object sender, RoutedEventArgs e)
        {
            num2 = Convert.ToDouble(pantalla.Text);

            switch (operador)
            {
                case "+":
                    pantalla.Text = $"{num1 + num2}";
                    break;

                case "-":
                    pantalla.Text = $"{num1 - num2}";
                    break;

                case "x":
                    pantalla.Text = $"{num1 * num2}";
                    break;

                case "/":
                    pantalla.Text = $"{num1 / num2}";
                    break;

                default:
                    Console.WriteLine("Selección no válida");
                    break;
            }
        }
    }
    
}