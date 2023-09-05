using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P3S5WebFormPageLifeCycle
{
    public partial class _Default : Page
    {
        string log = "";
        protected void Page_PreInit(object sender, EventArgs e)
        {
            log += "page_preinit()<br>";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            log += "page_init()<br>";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            log += "page_initcomplete()<br>";
        }
        protected override void OnPreLoad( EventArgs e)
        {
            log += "onpreload()<br>";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            log += "page_load()<br";
            lblName.Text = log;
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            log += "Page_LoadComplete()<br>";
        }
        protected override void OnPreRender( EventArgs e)
        {
            log += "onprerender()<br>";
        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
           log+="onsavestatecomplete()<br>";
        }
        protected void Page_UnLoad(object sender, EventArgs e)
        {

        }
    }
}