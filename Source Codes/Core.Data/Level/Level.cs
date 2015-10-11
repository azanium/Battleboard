using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Data.Level
{
    public class Level
    {
        #region MemVars & Props

        public event Action<Level> OnLevelResized = null;

        private double _width = 480;
        public double Width
        {
            get { return _width; }
            set 
            {
                if (_width != value)
                {
                    _width = value;
                    if (OnLevelResized != null)
                    {
                        OnLevelResized(this);
                    }
                }
            }
        }

        private double _height = 320;
        public double Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    if (OnLevelResized != null)
                    {
                        OnLevelResized(this);
                    }
                }
            }
        }

        #endregion


        #region Ctor

        public Level()
        {
        }

        #endregion 


        #region Internal Methods


        #endregion


        #region Public Methods


        #endregion
    }
}
