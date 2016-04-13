using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace employeemanagement
{
    public partial class updateemp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_msg.Text = "Enter required Emp ID here then hit Search";
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

        protected void btnupdateemp_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.empid = Int32.Parse(txt_empid.Text);
            emp.initials = txt_initials.Text;
            emp.surname = txt_surname.Text;
            emp.name = txt_name.Text;
            emp.mobile = txt_mobile.Text;
            emp.curraddress= txt_curraddress.Text;
            emp.currdesignation = txt_currdesignation.Text;
            emp.currsalarypkg= (Int32.Parse(txt_currsalary.Text));
            emp.department = txt_department.Text;
            employeemanager empmanager = new employeemanager();
            empmanager.UpdateEmployee(emp);


        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}