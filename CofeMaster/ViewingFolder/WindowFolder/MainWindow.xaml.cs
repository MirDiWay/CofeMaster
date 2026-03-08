using CofeMaster.ConfigFolder.ClassFolder;
using CofeMaster.ViewingFolder.PageFolder;
using CofeMaster.ViewingFolder.UserControlFolder;
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

namespace CofeMaster.ViewingFolder.WindowFolder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            /* 
                При запуске окна происходит инициализация +
                Присваевается определённому Frame свойсво в определённом классе
                После выводится страница через класс
                Отправляюься данные для активации кнопки, что бы в итоге это выглядело красиво и безшовно
            */

            InitializeComponent();
            FrameNavigationClass.mainFrame_FNC = MainFrame;
            FrameNavigationClass.mainFrame_FNC.Navigate(new Favorites_Page());

            ControlMenuButton_UserControl.Favorites_ToggleButton.IsChecked = true;
            ControlMenuButton_UserControl.Favorites_ToggleButton.IsEnabled = false;
        }
    }
}
