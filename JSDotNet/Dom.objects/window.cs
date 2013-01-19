using JSDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.DOM.Objects
{
    public class window
    {

        public static JSFunctionCall alert(JSVariableString v)
        {
            return new JSFunctionCall("alert", v);
        }
        public static JSFunctionCall alert(string str)
        {
            return new JSFunctionCall("alert", new JSValueString(str));
        }
        public static JSFunctionCall alert(JSValueString str)
        {
            return new JSFunctionCall("alert", str);
        }


        public static location location
        {
            get
            {
                return JSDotNet.DOM.Objects.location.Instance;
            }
        }

        public static document document
        {
            get
            {
                return JSDotNet.DOM.Objects.document.Instance;
            }
        }
    }
}
