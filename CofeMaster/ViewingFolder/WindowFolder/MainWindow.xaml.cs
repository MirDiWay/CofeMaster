using CofeMaster.ConfigFolder.ClassFolder;
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
            InitializeComponent();
            Event_ConnectFramePage();
        }

        private void Event_ConnectFramePage()
        {
            //FrameNavigationClass.mainFrame_FNC = MainFrame;
            //FrameNavigationClass.mainFrame_FNC.Navigate(new AuthorizationPage());
        }
    }
}
