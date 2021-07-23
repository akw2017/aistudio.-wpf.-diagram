﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIStudio.Wpf.ADiagram.Demos.Flowchart
{
    /// <summary>
    /// 前端SelectOption
    /// </summary>
    public class SelectOption
    {
        public string value { get; set; }
        public string text { get; set; }

        public override string ToString()
        {
            return text;
        }
    }
}
