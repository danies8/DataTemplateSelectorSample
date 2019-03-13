using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DataTemplateSelectorSample
{
    public class AlternateTemplateSelector : DataTemplateSelector
    {
        public string OddTemplate { get; set; }
        public string EvenTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container) 
        {
            return (DataTemplate)((FrameworkElement)container).FindResource(
                (int)item % 2 == 0 ? EvenTemplate : OddTemplate);
        }
    }
}
