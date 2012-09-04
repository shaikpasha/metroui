using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;


namespace metroui.Views.Themes
{
   public  class ThemeView : UserControl
    {
       public ThemeView():base()
       {
           this.Resources.MergedDictionaries.Add(new Windows.UI.Xaml.ResourceDictionary{ Source=new Uri("ms-appx:/Common/DisplayThemeResources.xaml") });
       }
       public void LoadTheme()
       {
       }
    }
}
