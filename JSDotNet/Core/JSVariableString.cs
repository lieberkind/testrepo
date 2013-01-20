using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public class JSVariableString : JSValueString
    {
        public static implicit operator JSVariableString(string strValue)
        {
            return new JSVariableString(strValue);
        }
        public static implicit operator string(JSVariableString variable)
        {
            return variable.Value;
        }


        public JSVariableString(string name, string strValue)
            : base(strValue)
        {
            _Name = name;
        }
        public JSVariableString(string strValue)
            : base(strValue)
        {
            _Name = JSManager.UniqueIdentifierString();
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
