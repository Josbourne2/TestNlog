﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNLog.NetFramework
{
    class Worker
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public void DoStuff()
        {
            try
            {
                throw new Exception("Doing stuff went terribly wrong..");
            }
            catch(Exception ex)
            {
                logger.Fatal(ex);

            }
        }
    }
}
