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

namespace Day7CalculatorProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String firstnum;
        String secondnum;
        String oper;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button operators = (Button)sender;
            oper = operators.Content.ToString();
        }

        //private void btnsub_Click(object sender, RoutedEventArgs e)
        //{
        //    oper = btnsub.Content.ToString();
        //}

        //private void btnmul_Click(object sender, RoutedEventArgs e)
        //{
        //    oper = btnmul.Content.ToString();
        //}

        private void btneq_Click(object sender, RoutedEventArgs e)
        {
            int first = Convert.ToInt16(firstnum);
            int second = Convert.ToInt16(secondnum);
            int result = 0;
            switch (oper)
            {
                case "+":
                    {
                        result = first + second;
                        break;
                    }
                case "-":
                    {
                        result = first - second;
                        break;
                    }
                case "*":
                    {
                        result = first * second;
                        break;
                    }
                case "/":
                    {
                        result = first / second;
                        break;

                    }
            }
            resultbox.Text = result.ToString();
        }
     

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            firstnum = "";
            secondnum = "";
            resultbox.Clear();
            oper = "";
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button num = (Button)sender;
            if (oper == "")
            {
                firstnum = firstnum + num.Content.ToString();
                resultbox.Text = firstnum;
            }
            else
            {
                secondnum = secondnum + num.Content.ToString();
                resultbox.Text = secondnum;
            }
        }

        //private void btn2_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn2.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn2.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btn3_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn3.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn3.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btn7_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn7.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn7.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btn8_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn8.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn8.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btn9_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn9.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn9.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btn4_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn4.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn4.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btn5_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn5.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn5.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btn6_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn6.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn6.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        ////private void btndiv_Click(object sender, RoutedEventArgs e)
        ////{
        ////    oper = btndiv.Content.ToString();
        ////}

        //private void btn00_Click(object sender, RoutedEventArgs e)
        //{
        //    if (oper == "")
        //    {
        //        firstnum = firstnum + btn00.Content.ToString();
        //        resultbox.Text = firstnum;
        //    }
        //    else
        //    {
        //        secondnum = secondnum + btn00.Content.ToString();
        //        resultbox.Text = secondnum;
        //    }
        //}

        //private void btnsub_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
