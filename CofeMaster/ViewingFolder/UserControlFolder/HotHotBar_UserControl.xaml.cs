using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CofeMaster.ViewingFolder.UserControlFolder
{
    public partial class HotHotBar_UserControl : UserControl
    {
        public HotHotBar_UserControl()
        {
            InitializeComponent();
        }

        private void Polygon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /// перемещение окна при зажатии ЛКМ на полигоне
            Window window = Window.GetWindow(this);

            if (window != null)
            {
                window.DragMove();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            /// Закрытие окна при нажатии кнопки
            var window = Window.GetWindow(this);
            window?.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            /// Сворачиваем окно при нажатии кнопки
            var window = Window.GetWindow(this);
            if (window != null)
                window.WindowState = WindowState.Minimized;
        }
    }
}
