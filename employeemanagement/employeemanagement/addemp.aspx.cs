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
            ////create DBContext object
            //using (var context = new University_AdministrationEntities1())
            //{
            //    var empList = context.employees.ToList<employee>();

            //    //Add student in list
            //    empList.Add(new employee()
            //    {
            //        initials = "Mrertfghf",
            //        surname = "Afertealana",
            //        name = "Alpha",
            //        mobile = "98778678",
            //        curraddress = "aghfggsfgdfgdfghaf",
            //        currdesignation = "ederyfgfhf",
            //        currsalarypkg = 30000,
            //        department = "Mainhdfhe"

            //    });
            //    context.SaveChanges();











            }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source =.; Initial Catalog = \"University Administration\"; Integrated Security = True; MultipleActiveResultSets = True; Application Name = EntityFramework";
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "insert into employee(initials,surname,name,mobile,curraddress,currdesignation,currsalarypkg,department) values ('" + txt_initials.Text + "', '" + txt_surname.Text + "','" + txt_name.Text + "','" + txt_mobile.Text + "','" + txt_curraddress.Text + "','" + txt_currdesignation.Text + "', '" + Convert.ToInt32(this.txt_currsalary.Text) + "' ,'" + txt_department.Text + "')";
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
                {
                Response.Write("< script > alert('Data Inserted !!') </ script >    ");



            }
            else   
{
                Response.Write("< script > alert('Data Inserted !!') </ script > ");   
                }
            db.Close();

        }


    }

       
    }

    
