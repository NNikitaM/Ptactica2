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

namespace Zadanie5
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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(TbNumberA.Text);
                int st = A / 100;
                int ost = A % 100;
                int[] s = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                int k;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == st)
                    {
                        if (ost >= 01)
                        {
                            k = s[i] + 1;
                            TextBlockAnswer.Text = $"Ответ:\n{k} столетие";
                            break;
                        }
                        else
                        {
                            k = s[i];
                            TextBlockAnswer.Text = $"Ответ:\n{k} столетие";
                            break;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
