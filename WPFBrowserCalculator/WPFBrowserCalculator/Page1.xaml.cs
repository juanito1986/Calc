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
using ClassLibrary;
using NCalc;

namespace WPFBrowserCalculator
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Object n = 1;
            res.AppendText(n.ToString());
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Object n = 0;  
            res.AppendText(n.ToString());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Object n = 3;
            res.AppendText(n.ToString());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Object n = 4;
            res.AppendText(n.ToString());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Object n = 5;
            res.AppendText(n.ToString());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Object n = 6;
            res.AppendText(n.ToString());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Object n = 7;
            res.AppendText(n.ToString());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Object n = 8;
            res.AppendText(n.ToString());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Object n = 9;
            res.AppendText(n.ToString());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Object n = 2;
            res.AppendText(n.ToString());
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            Object plus = '+';
            res.AppendText(plus.ToString());
        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {
            Object minus = '-';
            res.AppendText(minus.ToString());
        }

        private void Button_Click_DividedBy(object sender, RoutedEventArgs e)
        {
            Object dividedby = '/';
            res.AppendText(dividedby.ToString());
        }

        private void Button_Click_For(object sender, RoutedEventArgs e)
        {
            Object prod = '*';
            res.AppendText(prod.ToString());
        }

        private void equal_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!(res.Text.ToString() == String.Empty))
            {
                Object x=0;
                x = Calculator.EvaluateExpression(res.Text.ToString());
                res.Clear();
                res.AppendText(x.ToString());
            }
            else
            {
                res.Clear();
                res.AppendText("Syntax error...");
            }
        }

        private void Button_Click_CE(object sender, RoutedEventArgs e)
        {
            res.Clear();
        }

    }
}
