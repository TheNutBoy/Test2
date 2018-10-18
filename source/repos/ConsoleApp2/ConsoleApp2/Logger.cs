﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace ConsoleApp2
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger("LOGGER");

        public static ILog Log { get; } = log;

        public static void InitLogger() => XmlConfigurator.Configure();
    }
}
