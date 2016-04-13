using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace employeemanagement
{
    public partial class addemp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
         }

        protected void btnaddemp_Click(object sender, EventArgs e)
        {

            //Create an employee object and populate its properties with your employee data
            employee newemployee = new employee();

            newemployee.initials = txt_initials.Text;
            newemployee.surname = txt_surname.Text;
            newemployee.name = txt_name.Text;
            newemployee.mobile = txt_mobile.Text;
            newemployee.curraddress = txt_curraddress.Text;
            newemployee.currdesignation = txt_currdesignation.Text;
            newemployee.currsalarypkg = Convert.ToInt32(txt_currsalary.Text);
            newemployee.department = txt_department.Text;



            //Create a new employee Manager that allows you to insert a new employee to database
            employeemanager empmanager = new employeemanager();

            empmanager.insertemployee(newemployee);
        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }   
    }

       
   
    
