using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_1
{
    public partial class Trans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            double d_value = 66.0; // 初始化一個雙精準浮點數變數值為d_value為66
            double celsius = 0.0;  // 初始化一個雙精準浮點數變數值Celsius為0

            d_value = Math.Round((celsius * 1.8) + 32, 2); // 轉換計算
            Response.Write($"{d_value}°F, C{celsius}"); // 印出結果
        }

    }

}