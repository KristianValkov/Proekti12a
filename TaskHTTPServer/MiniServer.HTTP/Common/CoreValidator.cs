using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.HTTP.Common
{
    public class CoreValidator
    {
        public static void ThrowNull(object obj ,string name)
        {
            if(obj == null)
            {
                throw new ArgumentException(name);
            }
        }
        public static void ThrowNullOrEmpty(string text, string name)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException(message: $"{ name} cannot be null or empty.",name);
            }
        }
    }
}
