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
    using CodeGenerator;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Generator _generator;

        public MainWindow()
        {
            InitializeComponent();
            _generator = new Generator() { Assembly = System.Reflection.Assembly.GetExecutingAssembly() };
            RegistTypesInCb();
            RegistSearchModels();
        }

        private void RegistTypesInCb()
        {
            var types = _generator.GetTypes();
            foreach (var item in types)
            {
                cb_typesSelect.Items.Add(new ComboBoxItem()
                {
                    Content = string.Format("{0}: {1}", item.Name, item.Namespace),
                    Tag = item
                });
            }
            cb_typesSelect.SelectedIndex = 0;
        }

        private void RegistSearchModels()
        {
            var types = _generator.GetTypesForSearch();

            foreach (var type in types)
            {
                lb_classesMulty.Items.Add(new ListBoxItem()
                {
                    Content = string.Format("{0}: {1}", type.Name, type.Namespace),
                    Tag = type
                });
            }
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
            var types = new List<Type>();
            types.Add(typeof(Models.Order));
            types.Add(typeof(Models.Person));
            types.Add(typeof(Models.Position));
            types.Add(typeof(Models.Region));
            
            if (cb_asSingleFileSimple.IsChecked.Value)
            {
                _generator.GenerateViewModelSimple(types, tb_saveFolderSimple.Text);
            }
            else
            {
                foreach (var item in types)
                {
                    _generator.GenerateViewModelSimple(item, this.tb_saveFolderSimple.Text);
                }
            }


            MessageBox.Show("Files created");
        }

        private void tb_savePathSelect_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FolderBrowserDialog folderPicker = new FolderBrowserDialog();

            var res = folderPicker.ShowDialog();

            switch (res)
            {
                case System.Windows.Forms.DialogResult.OK:
                    tb_savePathSelect.Text = folderPicker.SelectedPath;
                    break;
                case System.Windows.Forms.DialogResult.Yes:
                    tb_savePathSelect.Text = folderPicker.SelectedPath;
                    break;
                default:
                    break;

            }
        }

        private void btn_saveSelect_Click(object sender, RoutedEventArgs e)
        {
            var currentType = (cb_typesSelect.SelectedItem as ComboBoxItem).Tag as Type;
            _generator.GenerateViewModelSimple(currentType, tb_savePathSelect.Text);
            MessageBox.Show("Files created");
        }

        private void tb_savePathMulty_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            FolderBrowserDialog folderPicker = new FolderBrowserDialog();

            var res = folderPicker.ShowDialog();

            switch (res)
            {
                case System.Windows.Forms.DialogResult.OK:
                    tb_savePathMulty.Text = folderPicker.SelectedPath;
                    break;
                case System.Windows.Forms.DialogResult.Yes:
                    tb_savePathMulty.Text = folderPicker.SelectedPath;
                    break;
                default:
                    break;

            }
        }

        private void btn_saveMulty_Click(object sender, RoutedEventArgs e)
        {
            var types = lb_classesMulty.Items;

            var res = new List<Type>();

            foreach (ListBoxItem item in types)
            {
                if (item.IsSelected)
                {
                    res.Add(item.Tag as Type);
                }
            }

            _generator.GenerateViewModelSimple(res, tb_savePathMulty.Text);
            MessageBox.Show("Files created");
        }

        private void btn_generateProxySimple_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderPicker = new FolderBrowserDialog();

            var res = folderPicker.ShowDialog();

            var ctrlType = typeof(Controllers.EmployeeController);
            var type = typeof(Controllers.EmployeeVM);

            switch (res)
            {
                case System.Windows.Forms.DialogResult.OK:
                    _generator.GenerateHttpService(type, folderPicker.SelectedPath, ctrlType);
                    break;
                case System.Windows.Forms.DialogResult.Yes:
                    _generator.GenerateHttpService(type, folderPicker.SelectedPath, ctrlType);
                    break;
                default:
                    break;

            }

            MessageBox.Show("Files created");
        }
    }
}
