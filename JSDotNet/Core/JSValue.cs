using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Core
{
    public abstract class JSValue
    {
        internal abstract string ToScript();
    }
}
