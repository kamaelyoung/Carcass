﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

using Carcass.Data;
using MvcExtensions;

namespace Carcass.Infrastructure
{
    public class InitializeDatabase : BootstrapperTask
    {
        public override TaskContinuation Execute()
        {
            Database.SetInitializer<DatabaseContext>(new DatabaseContextInitializer());
            Data.DatabaseContextInitializer.InitializeMembership();

            return TaskContinuation.Continue;
        }
    }
}