using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metroui
{
    public enum TimeOfDay
    {
        Morning,
        Afternoon,
        Evening
    }

    public enum WeatherServiceFeed
    {
        Primary,
        Alternate
    }

    public enum TemperatureUnit
    {
        Celsius,
        Fahrenheit
    }

    public enum WeatherCategory
    {
        Sun,
        Cloudy,
        Wind,
        Storm,
        Snow,
        Rain,
        RainSnow,
        Night,
        Fog,
        Drizzle,
        None
    }

    public enum FirstDayOfWeek
    {
        Monday,
        Sunday
    }

    public enum ThemeComponents
    {
        Alarm,
        Weather,
        HourDigit1,
        HourDigit2,
        MinuteDigit1,
        MinuteDigit2,
        SecondDigit1,
        SecondDigit2,
        AmOrPm,
        DayOfWeek
    }

    public enum TimePeriod
    {
        AM,
        PM
    }
    public enum AlarmSound
    {
        Custom,
        Birds,
        Classic,
        Cuckoo,
        Glass,
        Modern,
        Oriental,
        Scream,
        Spring
    }


    public enum ScreenBrightnessMode
    {
        Dimmed,
        Normal
    }

}
