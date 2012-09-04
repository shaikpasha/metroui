using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Devices.Geolocation;

using metroui.Common;
namespace metroui.ViewModel
{
    class ApplicationViewModel : BindableBase
    {
        private bool _DisplaySeconds;
        public bool DisplaySeconds
        {
            get { return _DisplaySeconds; }
            set { base.SetProperty(ref _DisplaySeconds, value); }
        }
        private bool _DisplayDays;
        public bool DisplayDays
        {
            get { return _DisplayDays; }
            set { base.SetProperty(ref _DisplayDays, value); }
        }
        private Theme _CurrentTheme;
        public Theme CurrentTheme
        {
            get { return _CurrentTheme; }
            set { base.SetProperty(ref _CurrentTheme, value); }

 }

        private DateTime _CurrentTime;

        public DateTime CurrentTime
        {
            get { return _CurrentTime; }
            set { base.SetProperty(ref _CurrentTime, value); }
        }
        private ObservableCollection<Theme> _AvailableThemes;

        public ObservableCollection<Theme> AvailableThemes
        {
            get { return _AvailableThemes; }
            set { base.SetProperty(ref _AvailableThemes, value); }
        }
        private Theme _LoadTheme(string themeName)
        {
            var theme = new Theme
            {
                Name = themeName,
                BackgroundImage = string.Format("ms-appx:/Assets/Themes/{0}/background.png", themeName),
                SeparatorImage = string.Format("ms-appx:/Assets/Themes/{0}/separator.png", themeName),
                AmImage = string.Format("ms-appx:/Assets/Themes/{0}/am.png", themeName),
                PmImage = string.Format("ms-appx:/Assets/Themes/{0}/pm.png", themeName),
              //  AlarmDisabledImage = string.Format("ms-appx:/Assets/Themes/{0}/alarm-disabled.png", themeName),
                //AlarmEnabledImage = string.Format("ms-appx:/Assets/Themes/{0}/alarm-enabled.png", themeName),
            };

            for (int i = 0; i < 10; i++)
            {
                theme.LargeDigits.Add(new ThemeDigit { Value = i, Image = string.Format("ms-appx:/Assets/Themes/{0}/{1}-large-digit.png", themeName, i) });
                theme.SmallDigits.Add(new ThemeDigit { Value = i, Image = string.Format("ms-appx:/Assets/Themes/{0}/{1}-small-digit.png", themeName, i) });
            }

            //add the leading zero values also
            theme.LargeDigits.Add(new ThemeDigit { IsLeadingZero = true, Image = string.Format("ms-appx:/Assets/Themes/{0}/large-digit.png", themeName) });
            theme.SmallDigits.Add(new ThemeDigit { IsLeadingZero = true, Image = string.Format("ms-appx:/Assets/Themes/{0}/small-digit.png", themeName) });

            var daysOfWeek = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

            //mon -> sun
            foreach (var dayOfWeek in daysOfWeek)
            {
                theme.Days.Add(new ThemeDay
                {
                    FirstDayOfWeek = FirstDayOfWeek.Monday,
                    Value = dayOfWeek,
                    Image = string.Format("ms-appx:/Assets/Themes/{0}/mon_{1}.png", themeName, dayOfWeek.ToString().ToLower())
                });
            }

            //sun -> mon
            foreach (var dayOfWeek in daysOfWeek)
            {
                theme.Days.Add(new ThemeDay
                {
                    FirstDayOfWeek = FirstDayOfWeek.Sunday,
                    Value = dayOfWeek,
                    Image = string.Format("ms-appx:/Assets/Themes/{0}/sun_{1}.png", themeName, dayOfWeek.ToString().ToLower())
                });
            }
            return theme;
        }
    }
}
