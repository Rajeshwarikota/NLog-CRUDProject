using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProject
{
    class SwappingNumber
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Swap()
        {
            int a = 5;
            int b = 10;

            logger.Info("Before swapping: a = {0}, b = {1}", a, b);

            // Swap the values of a and b
            int temp = a;
            a = b;
            b = temp;

            logger.Info("After swapping: a = {0}, b = {1}", a, b);
        }
    }
}
