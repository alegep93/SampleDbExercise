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
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void grdProduct_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProduct.PageIndex = e.NewPageIndex;
            if (txtSuppName.Text == "" && txtProdName.Text == "" && txtPack.Text == "" && txtUnitPrice.Text == "" && txtDiscont.Text == "")
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
            List<Product> productList = new List<Product>();
            productList = ProductDAO.GetProductList();
            grdProduct.DataSource = productList;
            grdProduct.DataBind();
        }
        protected void SearchBind()
        {
            List<Product> productList = new List<Product>();
            productList = ProductDAO.SearchProduct(txtProdName.Text, txtSuppName.Text, txtPack.Text, txtUnitPrice.Text, txtDiscont.Text);
            grdProduct.DataSource = productList;
            grdProduct.DataBind();
        }
        /*** FINE HELPERS ***/
    }
}