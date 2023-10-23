using MiniServer.HTTP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniServer.HTTP.Headers
{
    internal class HttpHeader
    {
        public HttpHeader(string key,string value) 
        {
            CoreValidator.ThrowNullOrEmpty(text: key, name: nameof(key));
            CoreValidator.ThrowNullOrEmpty(text: value, name: nameof(value));
            this.Key = key;
            this.Value = value;
            public string Key { get;}
            public string Value { get;}
        public override string ToString()
        {
            return $"{this.Key}:{this.Value}";
        }
    }
    }
}
