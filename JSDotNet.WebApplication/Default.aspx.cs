using JSDotNet.DOM.Objects;
using JSDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Threading;

namespace JSDotNet.CoreWebApplication
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region Region: Embedded String Based Scripts
//            var script = @"
//                            function myAlert(msg) { alert('myAlert: ' + msg); }; myAlert('hello world');";

//            RegisterStartupScript(script);
            #endregion

            #region Region: Sandbox
            //var uP = new UpdatePanel() { UpdateMode = UpdatePanelUpdateMode.Conditional, ID = "uPWithProgress" };
            //form1.Controls.Add(uP);

            //var uPP = new UpdateProgress();
            //uPP.AssociatedUpdatePanelID = uP.UniqueID;
            //uPP.ProgressTemplate = new loadingTemplate();
            //form1.Controls.Add(uPP);

            //var b = new Button() { Text = DateTime.Now.ToString() };
            //b.Click += b_Click;
            //uP.ContentTemplateContainer.Controls.Add(b);


            //form1.Controls.Add(new Label() { Text = DateTime.Now.ToString() });

            //var tree = new TreeView();
            //var n1 = new TreeNode() { Text = "Node 1" };
            //var n2 = new TreeNode() { Text = "<font style='color: #000000; font-weight: bold;'>Node 2</font>" };



            //tree.Nodes.Add(n1);
            //tree.NodeStyle.ForeColor = Color.Gray;
            //tree.NodeStyle.Font.Bold = false;
            //tree.NodeStyle.Font.Size = FontUnit.Point(32);






            //n1.ChildNodes.Add(n2);

            //form1.Controls.Add(tree);
            #endregion


            var p = new Panel();
            p.Controls.Add(new Label() { Text = "Hello World!" });
            form1.Controls.Add(p);


            using (var JS = JSContext.Create)
            {
                var f = JS.function(new JSBlock()
                {
                    alert.Call("hello"),
                    window.alert("world") 
                });


                f.Call();

                //print(JS.ToHtmlString());
                RegisterStartupScript(JS.ToScript());
            }
            
        }

        

        void b_Click(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
        }
        private void print(string str)
        {
            form1.Controls.Add(new Label() { Text = str });
        }
        private void RegisterStartupScript(string script)
        {
            Page.ClientScript.RegisterStartupScript(GetType(), Guid.NewGuid().ToString(), script, true);
        }

    }

    class loadingTemplate : ITemplate
    {

        public void InstantiateIn(Control container)
        {
            container.Controls.Add(new Label() { Text = "LOADING" });
        }
    }
}