using JSDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.DOM.Objects
{
    public class document
    {
        
        public static document Instance
        {
            get
            {
                // todo: Make session singleton and not application singleton (as with static alone)
                if (_instance == null) _instance = new document() { };
                return _instance;
            }
        }
        private static document _instance;

        public static JSFunctionCall getElementById(JSVariableString v)
        {
            return new JSFunctionCall("getElementById", v);
        }
        public static JSFunctionCall getElementById(string str)
        {
            return new JSFunctionCall("getElementById", new JSValueString(str));
        }
        public static JSFunctionCall getElementById(JSValueString str)
        {
            return new JSFunctionCall("getElementById", str);
        }
    }
}
