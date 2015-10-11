using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using DevComponents.WpfRibbon;
using DoodleLand.Controllers;
using DoodleLand.UserControls;

namespace DoodleLand
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainController controller = MainController.Instance;

            this.DataContext = controller;

            controller.Loaded(this, rootCanvas, null);

            controller.Bind(ApplicationCommands.Close, CloseCommandExecute);
        }

        public void CloseCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
