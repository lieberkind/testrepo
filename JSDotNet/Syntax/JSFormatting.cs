using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JSDotNet.Syntax
{
    class JSFormatting
    {
        public static void SetLineBreak(string lineBreak)
        {
            lB = lineBreak;
        }
        private static string lB = Environment.NewLine;

        public static string LineBreak
        {
            get
            {
                return lB;
            }
        }
    }
}
