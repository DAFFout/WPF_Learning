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
using System.IO;
using Microsoft.Win32;

namespace WPF_Learning
{
    /// <summary>
    /// Interaction logic for OptionsFileDialog.xaml
    /// </summary>
    public partial class OptionsFileDialog : Window
    {
        public OptionsFileDialog()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text (*.txt)|*.txt|All File|*.*";
            if(ofd.ShowDialog() == true)
            {
                txteditor.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text (*.txt)|*.txt|All File|*.*";
            if(sfd.ShowDialog() == true) {
                File.WriteAllText(sfd.FileName, txteditor.Text);
                MessageBox.Show("Bạn đã lưu thành công", "Lưu văn bản", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
