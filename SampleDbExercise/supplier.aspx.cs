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
    public partial class supplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void grdSupplier_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdSupplier.PageIndex = e.NewPageIndex;
            if (txtSuppName.Text == "" && txtCompany.Text == "" && txtTitle.Text == "" && txtCity.Text == "" && txtCountry.Text == "" && txtPhone.Text == "" && txtFax.Text == "")
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
            List<Supplier> supplierList = new List<Supplier>();
            supplierList = SupplierDAO.GetSupplierList();
            grdSupplier.DataSource = supplierList;
            grdSupplier.DataBind();
        }
        protected void SearchBind()
        {
            List<Supplier> supplierList = new List<Supplier>();
            supplierList = SupplierDAO.SearchSupplier(txtSuppName.Text, txtCompany.Text, txtTitle.Text, txtCity.Text, txtCountry.Text, txtPhone.Text, txtFax.Text);
            grdSupplier.DataSource = supplierList;
            grdSupplier.DataBind();
        }
        /*** FINE HELPERS ***/
    }
}