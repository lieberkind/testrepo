using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public class JSVariableString : JSValue
    {
        public JSVariableString(string name)
        {
            _Name = name;
        }
        
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        private string _Name;

        internal override string ToScript()
        {
            return _Name;
        }
    }
}
