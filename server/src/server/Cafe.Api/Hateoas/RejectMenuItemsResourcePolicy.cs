﻿using Cafe.Api.Controllers;
using Cafe.Api.Resources.Tab;
using RiskFirst.Hateoas;
using System;

namespace Cafe.Api.Hateoas
{
    public class RejectMenuItemsResourcePolicy : IPolicy<RejectMenuItemsResource>
    {
        public Action<LinksPolicyBuilder<RejectMenuItemsResource>> PolicyConfiguration => policy =>
        {
            policy.RequireRoutedLink("self", nameof(TabController.RejectMenuItems));
            policy.RequireRoutedLink("order-items", nameof(TabController.OrderMenuItems));
            policy.RequireRoutedLink("serve-items", nameof(TabController.ServeMenuItems));
            policy.RequireRoutedLink("close", nameof(TabController.CloseTab));
        };
    }
}
