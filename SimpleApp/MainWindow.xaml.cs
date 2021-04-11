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

namespace SimpleApp
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


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string s = textBoxMass.Text;
            string[] s1 = s.Split(' ');
            int[] myArr = Array.ConvertAll(s1, n => int.Parse(n));


            int res = 0;
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 != 0)
                {
                    res += myArr[i];
                }
            }

            textBoxTotal.Text = res.ToString();

            /*for (int i = 0; i < myArr.Length; i++)
            {
                textBoxTotal.Text += myArr[i].ToString()+" ";
            }*/

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            

            string a = textBoxNumber.Text;
             int b =  Int32.Parse(a);

            string s = textBoxMass.Text;
            string[] s1 = s.Split(' ');
            int[] myArr = Array.ConvertAll(s1, n => int.Parse(n));

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] > b)
                {
                    textBoxTotal.Text += i + " ";
                }
            }

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string s = textBoxMass.Text;
            string[] s1 = s.Split(' ');
            int[] myArr = Array.ConvertAll(s1, n => int.Parse(n));

            int p = 0;

            for (int i = 0; i<myArr.Length; i++)
            {
                if (myArr[i] < p)
                {
                    p = myArr[i];

                }
            }

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] == p)
                {
                    myArr[i]=0;

                }
            }

            for( int i = 0; i< myArr.Length; i++)
            {
                textBoxTotal.Text += myArr[i] + " ";
            }

        }

       
    }   
}
