using JSDotNet.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public class JSDocumentFunction : JSBlockStatement
    {
        public static JSDocumentFunction Instance
        {
            get
            {
                // todo: Make session singleton and not application singleton (as with static alone)
                if (_instance == null) _instance = new JSDocumentFunction() { };
                return _instance;
            }
        }
        private static JSDocumentFunction _instance;
        private JSDocumentFunction()
        {
            
        }

        public override string ToScript()
        {
            var str = "";
            foreach (var st in Block)
            {
                str += st.ToScript() + ";" + JSFormatting.LineBreak;
            }
            return str;
        }
    }
}
