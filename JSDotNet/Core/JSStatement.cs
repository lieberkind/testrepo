using JSDotNet.Core.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JSDotNet.Core
{
    public abstract class JSStatement
    {

        public List<JSToken> Tokens
        {
            get
            {
                if (_Tokens == null) _Tokens = new List<JSToken>();
                return _Tokens;
            }
        }
        private List<JSToken> _Tokens;


        
        //public JSStatement Parent
        //{
        //    get
        //    {
        //        return _Parent;
        //    }
        //    set
        //    {
        //        if (_Parent != null) throw new Exception("Parent statement cannot be changed!");
        //        _Parent = value;
        //    }
        //}
        //private JSStatement _Parent;


        public abstract string ToScript();

        internal abstract void ExternalInheritanceProtection();
    }
}
