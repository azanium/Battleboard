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
using System.ComponentModel;

namespace DoodleLand.UserControls
{
    /// <summary>
    /// Interaction logic for ucBlock.xaml
    /// </summary>
    public partial class ucBlock : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public ucBlock()
        {
            InitializeComponent();

            DataContext = this;
            BlockWidth = 10;
            BlockHeight = 10;
        }

        public static DependencyProperty BlockWidthProperty = DependencyProperty.Register("BlockWidth", typeof(double), typeof(ucBlock));
        public static DependencyProperty BlockHeightProperty = DependencyProperty.Register("BlockHeight", typeof(double), typeof(ucBlock));

        public double BlockWidth
        {
            get { return (double)this.GetValue(BlockWidthProperty); }
            set
            {
                this.SetValue(BlockWidthProperty, value);
                NotifyPropertyChanged("BlockWidth");
            }
        }

        public double BlockHeight
        {
            get { return (double)this.GetValue(BlockHeightProperty); }
            set 
            {
                this.SetValue(BlockHeightProperty, value);
                NotifyPropertyChanged("BlockHeight");
            }
        }

    }
}
