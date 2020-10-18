using System;
using System.Collections.Generic;
using System.Text;

namespace Jan0660.TralseNet.Extensions
{
    public static class ExtensionMethods
    {
        public static bool NextBool(this Random random)
        {
            return random.Next(2) == 0;
        }
    }
}
