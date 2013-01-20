using JSDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

namespace JSDotNet
{
    public class JSManager
    {
        private void RegisterStartupScript(string script)
        {
            var p = (Page)(HttpContext.Current.Handler);
            p.ClientScript.RegisterStartupScript(p.GetType(), UniqueIdentifierString(), script);
        }

        public static string UniqueIdentifierString()
        {
            return "Guid" + Guid.NewGuid().ToString().RemoveIllegalCharacters();
        }
    }



    internal static class JSExtensions
    {


        internal static string CommaSeperate(this JSArgs args)
        {
            var str = "";
            if (args.Count > 0)
            {
                foreach (var v in args)
                {
                    str += v.ToScript() + ", ";
                }
                str = str.Substring(0, str.Length - 2);
            }
            return str;
        }


        internal static string RemoveIllegalCharacters(this String str)
        {
            return str.Replace("-", "");
        }


    }
}
