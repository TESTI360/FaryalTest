using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace employeemanagement
{
    public partial class deleteemp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnempsearch_Click(object sender, EventArgs e)
        {
            employeemanager empmanager = new employeemanager();
            employee emp = empmanager.Getemployee(Int32.Parse(txt_empid.Text));

            txt_empid.Text = emp.empid.ToString();
            txt_initials.Text = emp.initials;
            txt_surname.Text = emp.surname;
            txt_name.Text = emp.name;
            txt_mobile.Text = emp.mobile;
            txt_curraddress.Text = emp.curraddress;
            txt_currdesignation.Text = emp.currdesignation;
            txt_currsalary.Text = emp.currsalarypkg.ToString();
            txt_department.Text = emp.department;
        }

        protected void btndeleteemp_Click(object sender, EventArgs e)
        {
            employeemanager empmanager = new employeemanager();
            empmanager.DeleteEmployee(Int32.Parse(txt_empid.Text));
        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}