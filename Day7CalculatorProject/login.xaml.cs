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
using System.Windows.Shapes;

namespace Day7CalculatorProject
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        string uid = "Admin";
        string pwd = "Admin123";
        public login()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //method-4:(to check empty space )
            //if (txtusername.Text == "" || txtpassword.Password == "")
            //{
            //    MessageBox.Show("please check the username and password");
            //}

            //method-5:(to check the null & white space using [IsNullOrWhiteSpace] function) 
            if(string.IsNullOrWhiteSpace(txtusername.Text)==true || string.IsNullOrWhiteSpace(txtpassword.Password)==true)
            {
                MessageBox.Show("please check the user and password");
            }
            else
            {
                //method-3:(to  check the condition in one line)

                if (txtusername.Text == uid && txtpassword.Password == pwd)
                {
                    MessageBox.Show("welcome","jsquare",MessageBoxButton.OKCancel,MessageBoxImage.Exclamation);
                }
                else
                {
                    MessageBox.Show("username and password invalid");
                }
            }
            //method-2:
            //if (txtusername.Text == uid)
            //{
            //    if (txtpassword.Password == pwd)
            //    {
            //        MessageBox.Show("welcome");

            //    }
            //    else
            //    {
            //        MessageBox.Show("password invalid");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("please enter correct username and password");
            //}
         //method-1
         
        //    if(txtusername.Text==txtpassword.Password)
        //    {
        //        MessageBox.Show("welcome");
        //    }
        //    if(txtusername.Text != txtpassword.Password)
        //    {
        //        MessageBox.Show("Password invalid");
        //    }
        }
    }
}
