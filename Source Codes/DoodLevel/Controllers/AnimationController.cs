using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DoodleLand.Controllers.Interfaces;
using DoodleLand.UserControls;
using System.Windows;
using System.Windows.Controls;

namespace DoodleLand.Controllers
{
    public class AnimationController : ControllerBase
    {
        #region MemVars & Props

        private static AnimationController _instance = null;
        public static AnimationController Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AnimationController();
                }
                return _instance;
            }
        }

        #endregion


        #region Ctor

        public AnimationController()
        {
            View = new ucAnimationTool();
            (View as UserControl).DataContext = this;
            
            Loaded();
        }

        #endregion


        #region Public Methods

        public void Loaded()
        {

        }

        #endregion
    }
}
