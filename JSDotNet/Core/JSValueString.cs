using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public class JSValueString : JSValue
    {

        public static implicit operator JSValueString(string strValue)
        {
            return new JSValueString(strValue);
        }

        public JSValueString(string value)
        {
            this._value = value;
        }
        public string Value
        {
            get
            {
                return _value;
            }
        }
        private string _value;



        internal override string ToScript()
        {
            return "'" + _value + "'";
        }
    }
}
