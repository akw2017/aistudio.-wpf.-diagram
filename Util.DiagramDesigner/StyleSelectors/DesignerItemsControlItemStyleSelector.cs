﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Util.DiagramDesigner
{
    public class DesignerItemsControlItemStyleSelector : StyleSelector
    {
        static DesignerItemsControlItemStyleSelector()
        {
            Instance = new DesignerItemsControlItemStyleSelector();
        }

        public static DesignerItemsControlItemStyleSelector Instance
        {
            get;
            private set;
        }


        public override Style SelectStyle(object item, DependencyObject container)
        {
            ItemsControl itemsControl = ItemsControl.ItemsControlFromItemContainer(container);
            if (itemsControl == null)
                throw new InvalidOperationException("DesignerItemsControlItemStyleSelector : Could not find ItemsControl");

            if (item is GifImageItemViewModel)
            {
                return (Style)itemsControl.FindResource("gifimageItemStyle");
            }

            if (item is LinkPointDesignerItemViewModel)
            {
                return (Style)itemsControl.FindResource("linkpointItemStyle");
            }

            if (item is PointDesignerItemViewModel)
            {
                return (Style)itemsControl.FindResource("pointItemStyle");
            }

            if (item is LogicalGateItemViewModelBase)
            {
                return (Style)itemsControl.FindResource("logicalItemStyle");
            }

            if (item is DesignerItemViewModelBase)
            {

                return (Style)itemsControl.FindResource("designerItemStyle");
            }
            
            if (item is ConnectorViewModel)
            {
                return (Style)itemsControl.FindResource("connectorItemStyle");
            }           

            return null;
        }
    } 
}
