using System;
using System.Web.DynamicData;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using Nop.Core.Configuration;


namespace Bonner.Nop.Plugin.Misc.PickUpInStoreHours.Models
{
    public class ConfigurationModel : BaseNopModel, ISettings
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.PickupMethodName")]
        public string PickupMethodName { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.Rate")]
        public decimal Rate { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.LeadTime")]
        public int LeadTime { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabled")]
        public bool IsEnabled { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledSunday")]
        public bool IsEnabledSunday { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.SundayStart")]
        public string SundayStart { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.SundayEnd")]
        public string SundayEnd { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledMonday")]
        public bool IsEnabledMonday { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.MondayStart")]
        public string MondayStart { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.MondayEnd")]
        public string MondayEnd { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledTuesday")]
        public bool IsEnabledTuesday { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.TuesdayStart")]
        public string TuesdayStart { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.TuesdayEnd")]
        public string TuesdayEnd { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledWednesday")]
        public bool IsEnabledWednesday { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.WednesdayStart")]
        public string WednesdayStart { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.WednesdayEnd")]
        public string WednesdayEnd { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledThursday")]
        public bool IsEnabledThursday { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.ThursdayStart")]
        public string ThursdayStart { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.ThursdayEnd")]
        public string ThursdayEnd { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledFriday")]
        public bool IsEnabledFriday { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.FridayStart")]
        public string FridayStart { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.FridayEnd")]
        public string FridayEnd { get; set; }

        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledSaturday")]
        public bool IsEnabledSaturday { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.SaturdayStart")]
        public string SaturdayStart { get; set; }

        [DataType(DataType.Time)]
        [NopResourceDisplayName("Plugins.Misc.PickUpInStoreHours.Fields.SaturdayEnd")]
        public string SaturdayEnd { get; set; }
    }
}