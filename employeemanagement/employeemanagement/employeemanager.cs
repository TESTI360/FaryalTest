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
    public class employeemanager
    {

        public void insertemployee(employee emp)
        {

            //Create the SQL Query for inserting an emp
            string sqlQuery = String.Format("Insert into employee (initials,surname,name,mobile,curraddress,currdesignation,currsalarypkg,department) Values( '" + emp.initials + "','" + emp.surname + "', '" + emp.name + "', '" + emp.mobile + "', '" + emp.curraddress + "', '" + emp.currdesignation + "','" + emp.currsalarypkg + "', '" + emp.department + "')");



            //Create and open a connection to SQL Server 
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=\"University Administration\";Integrated Security=True");
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.ExecuteScalar();
            //int m = command.ExecuteNonQuery();
            //if (m != 0)
            //{
            //    Response.Write("< script > alert('Data Inserted !!') </ script >    ");


            //}

            //else
            //{
            //    Response.Write("< script > alert('Data Inserted !!') </ script > ");
            //}


            //Close and dispose
            command.Dispose();
            connection.Close();
            connection.Dispose();



        }

        public void UpdateEmployee(employee emp)
        {
            string checkquery = String.Format("Select name from employee where empid = '"+emp.empid +"'");
            //Create the SQL Query for inserting an emp
            string createQuery = String.Format("Insert into employee (initials,surname,name,mobile,curraddress,currdesignation,currsalarypkg,department) Values( '" + emp.initials + "','" + emp.surname + "', '" + emp.name + "', '" + emp.mobile + "', '" + emp.curraddress + "', '" + emp.currdesignation + "','" + emp.currsalarypkg + "', '" + emp.department + "')");

            //Create the SQL Query for updating an emp
            string updateQuery = String.Format("Update employee SET initials='" + emp.initials + "',surname ='" + emp.surname + "' , name ='" + emp.name + "', mobile = '" + emp.mobile + "',curraddress = '" + emp.curraddress + "', currdesignation = '" + emp.currdesignation + "', currsalarypkg = '" + emp.currsalarypkg + "', department ='" + emp.department + "' where empid = '"+emp.empid+"'");


            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=\"University Administration\";Integrated Security=True");

            //Create and open a connection to SQL Server 
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand(checkquery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            SqlCommand command1;
            if (dataReader.HasRows)
            command1= new SqlCommand(updateQuery, connection);
            else
            command1 = new SqlCommand(createQuery, connection);
            //Close and dispose
            command.Dispose();
            dataReader.Close();
            command1.ExecuteScalar();

            connection.Close();
            connection.Dispose();


        }

        public employee Getemployee(Int32 searchemp)
        {



            //Create the SQL Query for returning all the employees
            string sqlQuery = String.Format("select * from employee where empid = '" + searchemp + "'");
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=\"University Administration\";Integrated Security=True");

            //Create and open a connection to SQL Server 
            connection.Open();

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Create DataReader for storing the returning table into server memory
            SqlDataReader dataReader = command.ExecuteReader();

            employee emp = new employee();

            //load into the result object the returned row from the database
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {


                    emp.empid = Convert.ToInt32(dataReader["empid"]);
                    emp.initials = dataReader["initials"].ToString();
                    emp.surname = dataReader["surname"].ToString();
                    emp.name = dataReader["name"].ToString();
                    emp.mobile = dataReader["mobile"].ToString();
                    emp.curraddress = dataReader["curraddress"].ToString();
                    emp.currdesignation = dataReader["currdesignation"].ToString();
                    emp.currsalarypkg = Convert.ToInt32(dataReader["currsalarypkg"]);
                    emp.department = dataReader["department"].ToString();





                }



            }


            return emp;


        }

        public void DeleteEmployee(Int32 searchemp)
        {
            string checkquery = String.Format("Select name from employee where empid = '" + searchemp  + "'");
            string deleteQuery = String.Format("Delete from employee where empid = '"+searchemp +"'");

            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=\"University Administration\";Integrated Security=True");

            //Create and open a connection to SQL Server 
            connection.Open();

            //Create a Command object
            SqlCommand command = new SqlCommand(checkquery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            SqlCommand command1;
            if (dataReader.HasRows)
            {
                command1 = new SqlCommand(deleteQuery, connection);

                //Close and dispose
                command.Dispose();
                dataReader.Close();
                command1.ExecuteScalar();
                
            }
            else
            {
                command.Dispose();
                dataReader.Close();
            }
            connection.Close();
            connection.Dispose();

        }
    }
}