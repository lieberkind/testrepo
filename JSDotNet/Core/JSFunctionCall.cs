using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public class JSFunctionCall : JSStatement
    {
        #region Region: Constructors
        internal JSFunctionCall(JSFunction f)
        {
            this.f = f;
            this.args = new JSArgs();
        }
        internal JSFunctionCall(JSFunction f, JSArgs args)
        {
            this.f = f;
            this.args = args;
        }
        internal JSFunctionCall(string functionName, JSArgs args)
        {
            this.args = args;
            this._functionName = functionName;
        }
        internal JSFunctionCall(string functionName, JSValue arg)
        {
            this.args = new JSArgs() { arg };
            this._functionName = functionName;
        }
        #endregion

        #region Region: Function Data
        private JSFunction f;
        private string functionName
        {
            get
            {
                return f == null ? _functionName : f.Name;
            }
        }
        private string _functionName;

        private JSArgs args;
        #endregion




        public override string ToScript()
        {
            return functionName + "(" + args.CommaSeperate() + ")";
        }

        internal override void ExternalInheritanceProtection()
        {
            throw new NotImplementedException();
        }
    }


}
