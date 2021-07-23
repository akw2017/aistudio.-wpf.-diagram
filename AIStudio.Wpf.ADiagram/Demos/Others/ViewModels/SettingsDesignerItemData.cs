﻿using Util.DiagramDesigner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIStudio.Wpf.ADiagram.Models;

namespace AIStudio.Wpf.ADiagram.Demos.Others
{
    /// <summary>
    /// This is passed to the PopupWindow.xaml window, where a DataTemplate is used to provide the
    /// ContentControl with the look for this data. This class is also used to allow
    /// the popup to be cancelled without applying any changes to the calling ViewModel
    /// whos data will be updated if the PopupWindow.xaml window is closed successfully
    /// </summary>
    public class SettingsDesignerItemData : TitleBindableBase
    {
       

        public SettingsDesignerItemData(string currentSetting1)
        {
            Setting1 = currentSetting1;
        }

        private string _setting1 = "";
        public string Setting1
        {
            get
            {
                return _setting1;
            }
            set
            {
                SetProperty(ref _setting1, value);
            }
        }
    }
}
