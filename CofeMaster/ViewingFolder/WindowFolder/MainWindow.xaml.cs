using CofeMaster.ConfigFolder.ClassFolder;
using CofeMaster.ViewingFolder.PageFolder;
using System.Windows;

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
            FrameNavigationClass.mainFrame_FNC.Navigate(new Range_Page());

            ControlMenuButton_UserControl.Range_ToggleButton.IsChecked = true;
            ControlMenuButton_UserControl.Range_ToggleButton.IsEnabled = false;
        }
    }
}
