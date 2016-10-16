using Microsoft.Win32;
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

namespace DesktopClient
{
    using System.Windows.Forms;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb_saveFolderSimple_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FolderBrowserDialog folderPicker = new FolderBrowserDialog();

            var res = folderPicker.ShowDialog();

            switch (res)
            {
                case System.Windows.Forms.DialogResult.OK:
                    tb_saveFolderSimple.Text = folderPicker.SelectedPath;
                    break;
                case System.Windows.Forms.DialogResult.Yes:
                    tb_saveFolderSimple.Text = folderPicker.SelectedPath;
                    break;
                default:
                    break;

            }
            
        }

        private void btn_saveSimple_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
