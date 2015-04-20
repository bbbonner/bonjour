using Nop.Core.Configuration;
using Bonner.Nop.Plugin.Misc.PickUpInStoreHours;
using System;
namespace Bonner.Nop.Plugin.Misc.PickUpInStoreHours
{
    public class PickUpInStoreHoursSettings : ISettings
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        public string PickupMethodName { get; set; }

        public decimal Rate { get; set; }

        public bool IsEnabled { get; set; }

        public bool IsEnabledSunday { get; set; }

        public string SundayStart { get; set; }

        public string SundayEnd { get; set; }

        public bool IsEnabledMonday { get; set; }

        public string MondayStart { get; set; }

        public string MondayEnd { get; set; }

        public bool IsEnabledTuesday { get; set; }

        public string TuesdayStart { get; set; }

        public string TuesdayEnd { get; set; }

        public bool IsEnabledWednesday { get; set; }

        public string WednesdayStart { get; set; }

        public string WednesdayEnd { get; set; }

        public bool IsEnabledThursday { get; set; }

        public string ThursdayStart { get; set; }

        public string ThursdayEnd { get; set; }

        public bool IsEnabledFriday { get; set; }

        public string FridayStart { get; set; }

        public string FridayEnd { get; set; }

        public bool IsEnabledSaturday { get; set; }

        public string SaturdayStart { get; set; }

        public string SaturdayEnd { get; set; }
    }
}