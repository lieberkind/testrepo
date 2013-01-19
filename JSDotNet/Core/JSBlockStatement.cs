using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public abstract class JSBlockStatement : JSStatement
    {
        public JSBlockStatement()
        {
            Block = new JSBlock();
        }

        public JSBlock Block { get; set; }

        //public JSStatements SetBody
        //{
        //    get
        //    {
        //        return _Body;
        //    }
        //    set
        //    {
        //        _Body = value;
        //        _Body.Owner = Block;
        //    }
        //}
        //public JSDocument Body(JSStatements body)
        //{
        //    //body.Owner = Block;
        //    _Body = body;
        //    return this.Parent;
        //}
        //private JSStatements _Body;


        //public List<JSStatement> Statements
        //{
        //    get
        //    {
        //        if (_Statements == null) _Statements = new List<JSStatement>();
        //        return _Statements;
        //    }
        //}
        //private List<JSStatement> _Statements;

        //public override string ToScript()
        //{
        //    throw new NotImplementedException();
        //}

        internal override void ExternalInheritanceProtection()
        {
            throw new NotImplementedException();
        }

    }
}
