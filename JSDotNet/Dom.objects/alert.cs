using JSDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.DOM.Objects
{
    public class alert
    {
        public static JSFunctionCall Call(JSVariableString v)
        {
            return window.alert(v);
        }
        public static JSFunctionCall Call(string str)
        {
            return window.alert(str);
        }
        public static JSFunctionCall Call(JSValueString str)
        {
            return window.alert(str);
        }
    }
}
