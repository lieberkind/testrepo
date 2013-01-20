using JSDotNet.Core;
using JSDotNet.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JSDotNet
{
    public class JSContext : IDisposable
    {
        public static JSContext Create
        {
            get
            {
                return new JSContext();
            }
        }
        private JSContext()
        {

        }

        private JSDocumentFunction document
        {
            get
            {
                return JSDocumentFunction.Instance;
            }
        }

        #region Region: Function Declaration
        public JSFunction function()
        {
            return RegisterStatement(new JSFunction(document) { Name = JSManager.UniqueIdentifierString() });
        }
        public JSFunction function(JSBlock body)
        {
            return RegisterStatement(new JSFunction(document) { Name = JSManager.UniqueIdentifierString(), Block = body });
        }
        public JSFunction function(string name)
        {
            return RegisterStatement(new JSFunction(document) { Name = name });
        }
        public JSFunction function(string name, JSBlock block)
        {
            return RegisterStatement(new JSFunction(document) { Name = name, Block = block });
        }
        protected JSStatement RegisterStatement(JSStatement statement)
        {
            JSDocumentFunction.Instance.Block.Add(statement);
            return statement;
        }
        protected JSFunction RegisterStatement(JSFunction statement)
        {
            JSDocumentFunction.Instance.Block.Add(statement);
            return statement;
        }
        #endregion

        public void Dispose()
        {
            //RegisterStartupScript(JSDocumentFunction.Instance.ToScript());
        }

        public string ToHtmlString()
        {
            JSFormatting.SetLineBreak("<br />");
            var str = JSDocumentFunction.Instance.ToScript();
            JSFormatting.SetLineBreak(Environment.NewLine);
            return str;
        }

        public string ToScript()
        {
            return JSDocumentFunction.Instance.ToScript();
        }

        //private void RegisterStartupScript(string script)
        //{
        //    var p = (Page)(HttpContext.Current.Handler);
        //    p.ClientScript.RegisterStartupScript(p.GetType(), Guid.NewGuid().ToString(), script, true);
        //}
    }
}
