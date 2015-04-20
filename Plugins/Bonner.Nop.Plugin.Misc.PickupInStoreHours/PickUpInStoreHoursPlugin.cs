using System;
using System.Collections.Generic;
using System.Web.Routing;
using Nop.Core.Plugins;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Common;
using Nop.Services.Configuration;
using Nop.Services.Stores;
using Nop.Core;

namespace Bonner.Nop.Plugin.Misc.PickUpInStoreHours
{
    /// <summary>
    /// Fixed rate shipping computation method
    /// </summary>
    public class PickUpInStoreHoursPlugin : BasePlugin, IMiscPlugin
    {
        #region Fields

        private readonly ISettingService _settingService;
        

        #endregion

        #region Ctor
        public PickUpInStoreHoursPlugin(ISettingService settingService)
        {
            this._settingService = settingService;
           
        }
        #endregion

        #region Properties
        
        #endregion

        #region Utilities

        private int GetLeadTime(int storeId)
        {           
            string key = string.Format("ShippingRateComputationMethod.PickUpInStoreHours.LeadTime", storeId);
            var leadTime = this._settingService.GetSetting("ShippingRateComputationMethod.PickUpInStoreHours.LeadTime", storeId, true);             
            return int.Parse(leadTime.Value);
        }
        #endregion

        #region Methods

        /// <summary>
        ///  Gets available shipping options
        /// </summary>
        /// <param name="getShippingOptionRequest">A request for getting shipping options</param>
        /// <returns>Represents a response of getting shipping rate options</returns>
        //public GetShippingOptionResponse GetShippingOptions(GetShippingOptionRequest getShippingOptionRequest)
        //{
        //    if (getShippingOptionRequest == null)
        //        throw new ArgumentNullException("getShippingOptionRequest");

        //    var response = new GetShippingOptionResponse();

        //    if (getShippingOptionRequest.Items == null || getShippingOptionRequest.Items.Count == 0)
        //    {
        //        response.AddError("No shipment items");
        //        return response;
        //    } 
        //    return response;
        //}

        /// <summary>
        /// Gets fixed shipping rate (if shipping rate computation method allows it and the rate can be calculated before checkout).
        /// </summary>
        /// <param name="getShippingOptionRequest">A request for getting shipping options</param>
        /// <returns>Fixed shipping rate; or null in case there's no fixed shipping rate</returns>
        //public decimal? GetFixedRate(GetShippingOptionRequest getShippingOptionRequest)
        //{
        //    if (getShippingOptionRequest == null)
        //        throw new ArgumentNullException("getShippingOptionRequest");

        //    int? restrictByCountryId = (getShippingOptionRequest.ShippingAddress != null && getShippingOptionRequest.ShippingAddress.Country != null) ? (int?)getShippingOptionRequest.ShippingAddress.Country.Id : null;
        //    var shippingMethods = this._shippingService.GetAllShippingMethods(restrictByCountryId);
            
        //    var rates = new List<decimal>();
        //    foreach (var shippingMethod in shippingMethods)
        //    {
        //        decimal rate = GetRate(shippingMethod.Id);
        //        if (!rates.Contains(rate))
        //            rates.Add(rate);
        //    }

        //    //return default rate if all of them equal
        //    if (rates.Count == 1)
        //        return rates[0];

        //    return null;
        //}

        /// <summary>
        /// Gets a route for provider configuration
        /// </summary>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route values</param>
        public void GetConfigurationRoute(out string actionName, out string controllerName, out RouteValueDictionary routeValues)
        {
            actionName = "Configure";
            controllerName = "PickUpInStoreHours";
            routeValues = new RouteValueDictionary { { "Namespaces", "Bonner.Nop.Plugin.Misc.PickUpInStoreHours.Controllers" }, { "area", null } };
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        public override void Install()
        {
            //var settings = new PickUpInStoreHoursSettings();
            
            //locales
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.PickupMethodName", "In Store Pickup Shipping method");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.Rate", "Rate");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.LeadTime", "Lead Time (minutes)");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabled", "IsEnabled");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledSunday", "Allow Pickup on Sunday");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SundayStart", "Sunday Hours Begin");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SundayEnd", "Sunday Hours End");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledMonday", "Allow Pickup on Monday");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.MondayStart", "Monday Hours Begin");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.MondayEnd", "Monday Hours End");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledTuesday", "Allow Pickup on Tuesday");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.TuesdayStart", "Tuesday Hours Begin");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.TuesdayEnd", "Tuesday Hours End");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledWednesday", "Allow Pickup on Wednesday");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.WednesdayStart", "Wednesday Hours Begin");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.WednesdayEnd", "Wednesday Hours End");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledThursday", "Allow Pickup on Thursday");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.ThursdayStart", "Thursday Hours Begin");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.ThursdayEnd", "Thursday Hours End");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledFriday", "Allow Pickup on Friday");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.FridayStart", "Friday Hours Begin");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.FridayEnd", "Friday Hours End");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledSaturday", "Allow Pickup on Saturday");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SaturdayStart", "Saturday Hours Begin");
            this.AddOrUpdatePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SaturdayEnd", "Saturday Hours End");

            base.Install();
        }


        /// <summary>
        /// Uninstall plugin
        /// </summary>
        public override void Uninstall()
        {
            //locales
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.PickupMethodName");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.Rate");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.LeadTime");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabled");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledSunday");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SundayStart");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SundayEnd");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledMonday");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.MondayStart");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.MondayEnd");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledTuesday");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.TuesdayStart");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.TuesdayEnd");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledWednesday");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.WednesdayStart");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.WednesdayEnd");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledThursday");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.ThursdayStart");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.ThursdayEnd");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledFriday");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.FridayStart");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.FridayEnd");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.IsEnabledSaturday");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SaturdayStart");
            this.DeletePluginLocaleResource("Plugins.Misc.PickUpInStoreHours.Fields.SaturdayEnd");
           
            base.Uninstall();
        }

        #endregion

   
    }
}
