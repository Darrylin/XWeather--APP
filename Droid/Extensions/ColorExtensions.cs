using Android.Graphics;
using System;

namespace XWeather.Droid
{
    public static class ColorExtensions
    {
        public static Tuple<Color[], int> GetTimeOfDayGradient(this WuLocation location, bool random = false)
        {
            var index = location.GetTimeOfDayIndex(random);

            return new Tuple<Color[], int>(Colors.Gradients[index], index);
        }
    }
}