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
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void grdCustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdCustomer.PageIndex = e.NewPageIndex;
            if (txtCognome.Text == "" && txtNome.Text == "" && txtCitta.Text == "" && txtPaese.Text == "" && txtTelefono.Text == "") {
                BindGrid();
            } else {
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
            List<Customer> customerList = new List<Customer>();
            customerList = CustomerDAO.GetCustomerList();
            grdCustomer.DataSource = customerList;
            grdCustomer.DataBind();
        }
        protected void SearchBind()
        {
            List<Customer> customerList = new List<Customer>();
            customerList = CustomerDAO.SearchCustomer(txtCognome.Text, txtNome.Text, txtCitta.Text, txtPaese.Text, txtTelefono.Text);
            grdCustomer.DataSource = customerList;
            grdCustomer.DataBind();
        }

        /*** FINE HELPERS ***/
    }
}