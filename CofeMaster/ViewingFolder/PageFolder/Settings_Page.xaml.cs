using CofeMaster.ConfigFolder.ClassFolder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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

namespace CofeMaster.ViewingFolder.PageFolder
{
    public partial class Settings_Page : Page
    {
        public Settings_Page()
        {
            InitializeComponent();
            UppDataInfo_Class uppDataInfo_Class = new UppDataInfo_Class();
            NumberVersion_TextBlock.Text = uppDataInfo_Class.currentVersion_UDIC;
            DateLastUpdate_TextBlock.Text = uppDataInfo_Class.DateLastUpdate_UDIC;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/MirDiWay/CofeMaster"); //открытие ссылки в браузере
            }
            catch (Exception)
            {
                MessageBox.Show("Возникли проблемы при открытии ссылки, возможно отсутстует подключение к интернету", "Что-то пошло не так", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
