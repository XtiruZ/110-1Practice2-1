using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_1
{
    public partial class BluePrint : System.Web.UI.Page
    {
        public class Man
        {
            public string s_Id;
            public float f_Hei;
            public float f_Wei;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Man o_Man = new Man();
            o_Man.s_Id = "A123456789";
            o_Man.f_Hei = 178.5f;
            o_Man.f_Wei = 72.8f;

            // s_Id value, f_Hei value, f_Wei value
            Response.Write("s_Id= " + o_Man.s_Id + ", " +
                "f_Hei=" + o_Man.f_Hei.ToString() + ", " +
                "f_Wei=" + o_Man.f_Wei.ToString()
                );
        }
    }
}