using ComboBoxMVVMExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ComboBoxMVVMExample.ViewModel
{
    public class DynamicDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null /* && item is Task*/)
            {
                DynamicDataModel model = item as DynamicDataModel;

                return (DataTemplate)element.FindResource(model.DisplayAs + "Template");
            }

            return null;
        }
    }

    public class DynamicCascadingComboInGridTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = container as FrameworkElement;

            if (element != null && item != null /* && item is Task*/)
            {
                DynamicCascadingComboInGridModel model = item as DynamicCascadingComboInGridModel;

                return (DataTemplate)element.FindResource(model.DisplayAs + "Template");
            }

            return null;
        }
    }

}
