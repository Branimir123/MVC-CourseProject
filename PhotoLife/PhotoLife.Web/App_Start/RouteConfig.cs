﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PhotoLife
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "UserDetails",
                url: "Profile/Details/{username}",
                defaults: new { controller = "Profile", action = "UserProfile" });

            routes.MapRoute(
                name: "PostDetails",
                url: "Post/Details/{postId}",
                defaults: new {controller = "Post", action = "Details"});

            routes.MapRoute(
                name: "NewsDetails",
                url: "News/Details/{newsId}",
                defaults: new { controller = "News", action = "Details" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
