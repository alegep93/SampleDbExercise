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
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void grdOrder_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdOrder.PageIndex = e.NewPageIndex;
            if (txtNumOrdine.Text == "" && txtData.Text == "" && txtCustomer.Text == "" && txtAmount.Text == "")
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
            List<Order> orderList = new List<Order>();
            orderList = OrderDAO.GetOrderList();
            grdOrder.DataSource = orderList;
            grdOrder.DataBind();
        }
        protected void SearchBind()
        {
            List<Order> orderList = new List<Order>();
            orderList = OrderDAO.SearchOrder(txtNumOrdine.Text, txtData.Text, txtCustomer.Text, txtAmount.Text);
            grdOrder.DataSource = orderList;
            grdOrder.DataBind();
        }
        /*** FINE HELPERS ***/
    }
}