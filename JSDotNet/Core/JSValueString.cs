using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public class JSValueString : JSValue
    {
        public JSValueString(string value)
        {
            this._value = value;
        }
        private string _value;

        internal override string ToScript()
        {
            return "'" + _value + "'";
        }
    }
}
