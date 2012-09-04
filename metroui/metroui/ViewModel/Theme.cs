using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metroui.ViewModel
{
    public class Theme
    {
        public string Name { get; set; }

        public string BackgroundImage { get; set; }

        public string AlarmEnabledImage { get; set; }

        public string AlarmDisabledImage { get; set; }

        public string AmImage { get; set; }

        public string PmImage { get; set; }

        public string SeparatorImage { get; set; }

        public IList<ThemeDigit> LargeDigits { get; set; }

        public IList<ThemeDigit> SmallDigits { get; set; }

        public IList<ThemeDay> Days { get; set; }

        public Theme()
        {
            this.LargeDigits = new List<ThemeDigit>();
            this.SmallDigits = new List<ThemeDigit>();
            this.Days = new List<ThemeDay>();
           
        }
    }
}
