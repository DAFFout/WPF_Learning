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

namespace WPF_Learning
{
    /// <summary>
    /// Interaction logic for max3so.xaml
    /// </summary>
    public partial class max3so : Window
    {
        public max3so()
        {
            InitializeComponent();
        }

        private void btnkq_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c, kq1,kq2;
            a = Convert.ToDouble(txtso1.Text);
            b = Convert.ToDouble(txtso2.Text);
            c = Convert.ToDouble(txtso3.Text);
            kq1 = Math.Max(a, b);
            kq2 = Math.Max(kq1, c);
            txtsolonnhat.Text = kq2.ToString();

        }
    }
}
