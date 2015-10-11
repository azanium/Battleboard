using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.WpfRibbon;

namespace DoodleLand.Controllers
{
    public class Commands
    {
        public static ButtonDropDownCommand NewLevel = new ButtonDropDownCommand("New Level", "NewLevelCommand", typeof(Ribbon));
        public static ButtonDropDownCommand OpenLevel = new ButtonDropDownCommand("Open Level", "OpenLevelCommand", typeof(Ribbon));
        public static ButtonDropDownCommand SaveLevel = new ButtonDropDownCommand("Save Level", "SaveLevelCommand", typeof(Ribbon));
        public static ButtonDropDownCommand SaveLevelAs = new ButtonDropDownCommand("Save Level As", "SaveLevelAsCommand", typeof(Ribbon));
        public static ButtonDropDownCommand CloseLevel = new ButtonDropDownCommand("Close Level", "CloseLevelCommand", typeof(Ribbon));

        public static ButtonDropDownCommand iPhone3GSizeCommand = new ButtonDropDownCommand("iPhone 3G", "iPhone3G", typeof(Ribbon));
        public static ButtonDropDownCommand iPhone4SizeCommand = new ButtonDropDownCommand("iPhone 4", "iPhone4", typeof(Ribbon));
        public static ButtonDropDownCommand iPadSizeCommand = new ButtonDropDownCommand("iPad", "iPad", typeof(Ribbon));

    }
}
