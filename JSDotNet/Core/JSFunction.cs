using JSDotNet.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public class JSFunction : JSBlockStatement
    {
        public string Name { get; set; }
        public JSFunction Body(JSBlock block)
        {
            Block = block;
            return this;
        }
        #region Region: Body Auxilary Functions
		public JSFunction Body(JSStatement s1, JSStatement s2)
        {
            Block = new JSBlock() { s1, s2 };
            return this;
        }
        public JSFunction Body(JSStatement s1, JSStatement s2, JSStatement s3)
        {
            Block = new JSBlock() { s1, s2, s3 };
            return this;
        }
        public JSFunction Body(JSStatement s1, JSStatement s2, JSStatement s3, JSStatement s4)
        {
            Block = new JSBlock() { s1, s2, s3, s4 };
            return this;
        }
        public JSFunction Body(JSStatement s1, JSStatement s2, JSStatement s3, JSStatement s4, JSStatement s5)
        {
            Block = new JSBlock() { s1, s2, s3, s4, s5 };
            return this;
        } 
	    #endregion



        internal JSFunction(JSBlockStatement parent)
        {
            // todo: Consider to include support for nested functions currently not supported!
            _Parent = parent;
        }
        public JSBlockStatement Parent
        {
            get
            {
                return _Parent;
            }
        }
        private JSBlockStatement _Parent;





        public JSFunctionCall Call(JSArgs args)
        {
            return RegisterFunctionCall(new JSFunctionCall(this, args));
        }
        public JSFunctionCall Call()
        {
            return RegisterFunctionCall(new JSFunctionCall(this));
        }
        private JSStatement RegisterStatement(JSStatement statement)
        {
            Parent.Block.Add(statement);
            return statement;
        }
        private JSFunctionCall RegisterFunctionCall(JSFunctionCall call)
        {
            Parent.Block.Add(call);
            return call;
        }

        public override string ToScript()
        {
            var lB = JSFormatting.LineBreak;

            var str = "function " + Name + "()" + lB + "{" + lB;
            foreach (JSStatement statement in Block)
            {
                // todo: maybe add identation if nested depth is available...
                str += statement.ToScript() + ";" + lB;
            }
            str += "}";
            return str;
        }
    }
}
