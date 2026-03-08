using CofeMaster.ConfigFolder.ClassFolder;
using CofeMaster.ViewingFolder.PageFolder;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CofeMaster.ViewingFolder.UserControlFolder
{
    public partial class MenuButton_UserControl : UserControl
    {

        public MenuButton_UserControl() /// тут прописывается, что происходит, если страница инициализированна
        {
            InitializeComponent();

            //Favorites_ToggleButton.IsChecked = true;
            //Favorites_ToggleButton.IsEnabled = false;
            //FrameNavigationClass.mainFrame_FNC.Navigate(new Favorites_Page());
        }

        private void MenuClick_ToggleButton(object sender, RoutedEventArgs e) /// что будет происходит при нажатии кнопки
        {
            ToggleButton toggleButton = (ToggleButton)sender;

            foreach (var child in StackToggleButtonMenu_StackPanel.Children) /// перебераем все дочерние элементы из родительского
            {
                if (child is ToggleButton btn) 
                {
                    /// отключаем всем свойстов Checked (они не нажаты) и включаем свойсто Enabled (на них сново можно нажать)
                    btn.IsChecked = false;
                    btn.IsEnabled = true;
                }
            }

            /// делаем так, что бы нажатую кнопку было видно, и что бы на неё нельзя было нажать
            toggleButton.IsChecked = true;
            toggleButton.IsEnabled = false;

            /// переход между страницами при нажатии соответсующей кнопки
            switch (toggleButton.Name)
            {
                case "Favorites_ToggleButton":
                    FrameNavigationClass.mainFrame_FNC.Navigate(new Favorites_Page());
                    break;

                case "Range_ToggleButton":
                    FrameNavigationClass.mainFrame_FNC.Navigate(new Range_Page());
                    break;

                case "Partners_ToggleButton":
                    FrameNavigationClass.mainFrame_FNC.Navigate(new Partners_Page());
                    break;

                case "Settings_ToggleButton":
                    FrameNavigationClass.mainFrame_FNC.Navigate(new Settings_Page());
                    break;
            }
        }
    }
}
