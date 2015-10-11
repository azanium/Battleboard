using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

using DoodleLand.Controllers.Interfaces;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;

namespace DoodleLand.Controllers
{
    public class MainController : ControllerBase, INotifyPropertyChanged
    {
        #region MemVars & Props

        public event PropertyChangedEventHandler PropertyChanged = null;
        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        private static MainController _instance = null;
        public static MainController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MainController();
                }
                return _instance;
            }
        }

        public UserControl BottomPaneTool
        {
            get;
            set;
        }

        public Canvas RootCanvas
        {
            get;
            set;
        }

        public Canvas ViewCanvas
        {
            get;
            set;
        }
    
        private double _canvasWidth = 480;
        public double CanvasWidth
        {
            get { return _canvasWidth; }
            set
            {
                if (_canvasWidth != value)
                {
                    _canvasWidth = value;
                    NotifyPropertyChanged("CanvasWidth");
                }
            }
        }

        private double _canvasHeight = 320;
        public double CanvasHeight
        {
            get { return _canvasHeight; }
            set
            {
                if (_canvasHeight != value)
                {
                    _canvasHeight = value;
                    NotifyPropertyChanged("CanvasHeight");
                }
            }
        }


        #endregion


        #region Ctor

        public MainController()
        {
        }

        #endregion


        #region Public Methods

        public override void Loaded(UIElement view)
        {
            base.Loaded(view);

        }

        public void Loaded(System.Windows.UIElement view, Canvas rootCanvas, Canvas viewCanvas)
        {
            this.Loaded(view);

            RootCanvas = rootCanvas;
            ViewCanvas = rootCanvas;

            BottomPaneTool = AnimationController.Instance.View as UserControl;

            ResetBindings();
        }

        public void ResetBindings()
        {
            this.Bind(Commands.NewLevel, this.NewLevel);
            this.Bind(Commands.OpenLevel, this.OpenLevel);
            this.Bind(Commands.SaveLevel, this.SaveLevel, this.CanSaveLevel);
            this.Bind(Commands.SaveLevelAs, this.SaveLevelAs, this.CanSaveLevelAs);
            this.Bind(Commands.CloseLevel, this.CloseLevel, this.CanCloseLevel);

            this.Bind(Commands.iPhone3GSizeCommand, this.iPhone3GSize);
            this.Bind(Commands.iPhone4SizeCommand, this.iPhone4Size);
            this.Bind(Commands.iPadSizeCommand, this.iPadSize);
        }

        #endregion


        #region Application Menu Delegates

        public void iPhone3GSize(object sender, ExecutedRoutedEventArgs e)
        {
            CanvasWidth = 480;
            CanvasHeight = 320;
        }

        public void iPhone4Size(object sender, ExecutedRoutedEventArgs e)
        {
            CanvasWidth = 960;
            CanvasHeight = 640;
        }
        
        public void iPadSize(object sender, ExecutedRoutedEventArgs e)
        {
            CanvasWidth = 1024;
            CanvasHeight = 768;
        }

        public void NewLevel(object sender, ExecutedRoutedEventArgs e)
        {
        }

        public void OpenLevel(object sender, ExecutedRoutedEventArgs e)
        {
        }

        public void SaveLevel(object sender, ExecutedRoutedEventArgs e)
        {
        }

        public void CanSaveLevel(object sender, CanExecuteRoutedEventArgs e)
        {
        }

        public void SaveLevelAs(object sender, ExecutedRoutedEventArgs e)
        {
        }

        public void CanSaveLevelAs(object sender, CanExecuteRoutedEventArgs e)
        {
        }

        public void CloseLevel(object sender, ExecutedRoutedEventArgs e)
        {
        }

        public void CanCloseLevel(object sender, CanExecuteRoutedEventArgs e)
        {
        }


        #endregion
    }
}
