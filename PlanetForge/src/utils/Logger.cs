using System;
using System.Collections.Generic;
using System.Text;

namespace PlanetForge.utils
{
    public class Logger
    {

        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Info(string str)
        {
            logger.Info(str);
        }

        public static void Trace(string str)
        {
            logger.Trace(str);
        }
        
        public static void Warn(string str) {
            logger.Warn(str);
        }

        public static void Error(Exception ex, string str)
        {
            logger.Error(ex, str);
        }


        public static void Error(string str)
        {
            logger.Error(str);
        }
    }
}
