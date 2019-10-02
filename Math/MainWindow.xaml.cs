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

namespace Math
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int s1=0, s2=0, s3=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tinh_Click(object sender, RoutedEventArgs e)
        {
            string name = txbname.Text;
            int n = Int32.Parse(name);

            if ((bool)tong.IsChecked)
            {
                for (int i = 1; i <= n; i++)
                    s1 += i;
            }
            else
                if ((bool)tongle.IsChecked)
                {
                    for (int i = 1; i <= n; i++)
                        if (i % 2 != 0)
                            s2 += i;
                }
                else
                    if ((bool)tongchan.IsChecked)
                    {

                        for (int i = 1; i <= n; i++)
                            if (i % 2 == 0)
                                s3 += i;
                    }
                    else
                        MessageBox.Show("hay chon phep tinh");


            txbtong.Text = s1.ToString();
            txbtongle.Text = s2.ToString();
            txbtongchan.Text = s3.ToString();
        }


        private void huy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
