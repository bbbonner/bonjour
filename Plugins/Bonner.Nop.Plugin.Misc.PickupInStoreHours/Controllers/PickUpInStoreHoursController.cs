using System.Collections.Generic;
using System.Web.Mvc;
using Nop.Core;
using Bonner.Nop.Plugin.Misc.PickUpInStoreHours.Models;
using Nop.Services.Configuration;
using Nop.Services.Security;
using Nop.Services.Stores;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Kendoui;
using Nop.Web.Framework.Mvc;
using Nop.Core.Plugins;
using Nop.Core.Caching;
using Nop.Services.Localization;

namespace Bonner.Nop.Plugin.Misc.PickUpInStoreHours.Controllers
{
    [AdminAuthorize]
    public class PickUpInStoreHoursController : BasePluginController
    {        
        private readonly ISettingService _settingService;
        private readonly IPermissionService _permissionService;
        private readonly IStoreContext _storeContext;
        private readonly IStoreService _storeService;
        private readonly IPluginFinder _pluginFinder;
        private readonly IWorkContext _workContext;
        private readonly ICacheManager _cacheManager;
        private readonly ILocalizationService _localizationService;

        public PickUpInStoreHoursController(
            ISettingService settingService, 
            IPermissionService permissionService,
             IStoreContext storeContext,
            IStoreService storeService,
             IWorkContext workContext,
            IPluginFinder pluginFinder,
            ICacheManager cacheManager,
            ILocalizationService localizationService)
        {
            this._settingService = settingService;
            this._permissionService = permissionService;
            this._storeContext = storeContext;
            this._storeService = storeService;
            this._workContext = workContext;
            this._pluginFinder = pluginFinder;
            this._cacheManager = cacheManager;
            this._localizationService = localizationService;
        }
        
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            //little hack here
            //always set culture to 'en-US' (Telerik has a bug related to editing decimal values in other cultures). Like currently it's done for admin area in Global.asax.cs
            CommonHelper.SetTelerikCulture();

            base.Initialize(requestContext);
        }

        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageShippingSettings))
                return Content("Access denied");
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var model = _settingService.LoadSetting<ConfigurationModel>(storeScope);            
            model.ActiveStoreScopeConfiguration = storeScope;

           
            //TODO: limit to store
            if (storeScope > 0)
            {
            }
            return View("~/Plugins/Bonner.Nop.Plugin.Misc.PickUpInStoreHours/Views/PickUpInStoreHours/Configure.cshtml", model);
        }

        [HttpPost]
        public ActionResult Configure(ConfigurationModel model)
        {
            if (!_permissionService.Authorize(StandardPermissionProvider.ManageShippingSettings))
                return Content("Access denied");
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var settings = _settingService.LoadSetting<ConfigurationModel>(storeScope);

            //settings.ActiveStoreScopeConfiguration = storeScope;
            //settings.Rate = model.Rate;
            //settings.IsEnabled = model.IsEnabled;
            //settings.IsEnabledSunday = model.IsEnabledSunday;
            //settings.SundayStart = model.SundayStart;
            //settings.SundayEnd = model.SundayEnd;
            //settings.IsEnabledMonday = model.IsEnabledMonday;
            //settings.MondayStart = model.MondayStart;
            //settings.MondayEnd = model.MondayEnd;
            //settings.IsEnabledTuesday = model.IsEnabledTuesday;
            //settings.TuesdayStart = model.ThursdayStart;
            //settings.TuesdayEnd = model.TuesdayEnd;
            //settings.IsEnabledWednesday = model.IsEnabledWednesday;
            //settings.WednesdayStart = model.WednesdayStart;
            //settings.WednesdayEnd = model.WednesdayEnd;
            //settings.IsEnabledThursday = model.IsEnabledThursday;
            //settings.ThursdayStart = model.ThursdayStart;
            //settings.ThursdayEnd = model.ThursdayEnd;
            //settings.IsEnabledFriday = model.IsEnabledFriday;
            //settings.FridayStart = model.FridayStart;
            //settings.FridayEnd = model.FridayEnd;
            //settings.IsEnabledSaturday = model.IsEnabledSaturday;
            //settings.SaturdayStart = model.SaturdayStart;
            //settings.SaturdayEnd = model.SaturdayEnd;

            /* We do not clear cache after each setting update.
            * This behavior can increase performance because cached settings will not be cleared 
            * and loaded from database after each update */
            if (storeScope == 0)
                _settingService.SaveSetting(settings, x => x.ActiveStoreScopeConfiguration, storeScope, false);
            else if (storeScope > 0)
                _settingService.DeleteSetting(settings, x => x.ActiveStoreScopeConfiguration, storeScope);

            _settingService.SaveSetting(settings, x => x.Rate, storeScope, false);
            _settingService.SaveSetting(settings, x => x.SundayStart, storeScope, false);
            //TODO: limit to store
            if (storeScope > 0)
            {
            }
             _settingService.SaveSetting(model, storeScope);



            SuccessNotification(_localizationService.GetResource("Admin.Plugins.Saved"));
            //return Configure();
             return View("~/Plugins/Bonner.Nop.Plugin.Misc.PickUpInStoreHours/Views/PickUpInStoreHours/Configure.cshtml", model);
        }

        //[HttpPost]
        //public ActionResult ShippingRateUpdate(PickUpInStoreHoursModel model)
        //{
        //    if (!_permissionService.Authorize(StandardPermissionProvider.ManageShippingSettings))
        //        return Content("Access denied");

        //    int shippingMethodId = model.ShippingMethodId;
        //    decimal rate = model.Rate;
        //    bool isEnabled = model.IsEnabled;
        //    _settingService.SetSetting(string.Format("ShippingRateComputationMethod.PickUpInStoreHours.Rate.ShippingMethodId{0}", shippingMethodId), rate);
        //    _settingService.SetSetting(string.Format("ShippingRateComputationMethod.PickUpInStoreHours.IsEnabled.ShippingMethodId{0}", shippingMethodId), isEnabled);


        //    return new NullJsonResult();
        //}

        //[NonAction]
        //protected decimal GetShippingRate(int shippingMethodId)
        //{
        //    var rate = this._settingService.GetSettingByKey<decimal>(string.Format("ShippingRateComputationMethod.PickUpInStoreHours.Rate.ShippingMethodId{0}", shippingMethodId));
        //    return rate;
        //}

        //[NonAction]
        //protected bool GetShippingIsEnabled(int shippingMethodId)
        //{
        //    bool isEnabled = this._settingService.GetSettingByKey<bool>(string.Format("ShippingRateComputationMethod.PickUpInStoreHours.IsEnabled.ShippingMethodId{0}", shippingMethodId));
        //    return isEnabled;
        //}
        //[NonAction]
        //protected int GetLeadTime(int taxCategoryId)
        //{
        //    var rate = this._settingService.GetSettingByKey<int>(string.Format("Tax.TaxProvider.FixedRate.TaxCategoryId{0}", taxCategoryId));
        //    return rate;

        //    string key = string.Format("ShippingRateComputationMethod.PickUpInStoreHours.LeadTime", storeId);
        //    var leadTime = this._settingService.GetSetting("ShippingRateComputationMethod.PickUpInStoreHours.LeadTime", storeId, true);
        //    return int.Parse(leadTime.Value);
        //}
    }
}
