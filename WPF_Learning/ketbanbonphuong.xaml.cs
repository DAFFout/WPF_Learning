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
    /// Interaction logic for ketbanbonphuong.xaml
    /// </summary>
    public partial class ketbanbonphuong : Window
    {
        public ketbanbonphuong()
        {
            InitializeComponent();
        }

        private void cbonamsinh_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            

            // hien thi cac comboitem 
            for(int i = 1950; i <= 2020; i++)
            {
                cbonamsinh.Items.Add(i);
                if(i==2000)
                    cbonamsinh.SelectedItem = i;
                
            }
        }

        private void btnketban_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đã gửi lời mới kết bạn của bạn đến với Cộng đồng", "Kết Bạn", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnnhaplai_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ans = MessageBox.Show("Bạn có muốn nhập lại không ?", "Nhập lại", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(ans == MessageBoxResult.Yes)
            {
                txthoten.Clear();
                rdonam.IsChecked = true;
                rdonu.IsChecked = false;
                cbonamsinh.SelectedIndex = 1990;
                chodocsach.IsChecked = false;
                chodulich.IsChecked = false;
                chothethao.IsChecked = false;
                chonauan.IsChecked = false;
                txtloimuonnoi.Clear();


            }
        }
        private void btnthoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ans = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(ans == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
