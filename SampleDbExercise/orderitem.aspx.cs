using SampleDbExercise.DAO;
using SampleDbExercise.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDbExercise
{
    public partial class orderitem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void grdOrderItem_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdOrderItem.PageIndex = e.NewPageIndex;
            if (txtOrdNum.Text == "" && txtProdName.Text == "" && txtUnitPrice.Text == "" && txtQnt.Text == "")
            {
                BindGrid();
            }
            else
            {
                SearchBind();
            }
        }

        /*** CLICK EVENT ***/
        protected void btnCerca_Click(object sender, EventArgs e)
        {
            SearchBind();
        }

        /*** FINE CLICK EVENT ***/

        /******* HELPERS *******/
        protected void BindGrid()
        {
            List<OrderItem> orderItemList = new List<OrderItem>();
            orderItemList = OrderItemDAO.GetOrderItemList();
            grdOrderItem.DataSource = orderItemList;
            grdOrderItem.DataBind();
        }
        protected void SearchBind()
        {
            List<OrderItem> orderItemList = new List<OrderItem>();
            orderItemList = OrderItemDAO.SearchOrderItem(txtProdName.Text, txtOrdNum.Text, txtUnitPrice.Text, txtQnt.Text);
            grdOrderItem.DataSource = orderItemList;
            grdOrderItem.DataBind();
        }
        /*** FINE HELPERS ***/
    }
}