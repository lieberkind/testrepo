using JSDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.DOM.Objects
{
    public class location
    {
        public static location Instance
        {
            get
            {
                // todo: Make session singleton and not application singleton (as with static alone)
                if (_instance == null) _instance = new location() { };
                return _instance;
            }
        }
        private static location _instance;

        // Todo: Implement Property
        //public static JSFunctionCall hash
        //{
        //    get
        //    {
        //        return new JSFunctionCall("location.hash");
        //    }
        //}
    }
}
