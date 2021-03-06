﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Routing;

using Carcass.Common.MVC;
using MvcExtensions;
using log4net;


namespace Carcass.Infrastructure.Tasks
{
    public class InitializeCarcass : BootstrapperTask
    {
        public InitializeCarcass()
        {
            Log = LogManager.GetLogger("InitializeCarcass");
        }


        private ILog Log { get; set; }

        public override TaskContinuation Execute()
        {
            var appAssembly = typeof(Carcass.MvcApplication).Assembly;

            Bootstrap.Init();
            Bootstrap.SetupValidators(appAssembly, "Carcass.Models");

            return TaskContinuation.Continue;
        }
    }
}