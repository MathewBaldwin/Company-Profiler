using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Text;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string CompanyURL { get; set; }

        //Added functionally if out of requests. Uncomment next line
        //public static string CompanyURL = File.ReadAllText(@"C:\Users\honda\Desktop\ShoppingList.txt");
        public string sitePath { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            sitePath = domainTextBox.Text;
        }

        protected void domainTextBox_TextChanged(object sender, EventArgs e)
        {
            //Setting the string to be used in a later method. Grabbing users input text to set variable.
            CompanyURL = domainTextBox.Text;
        }

        protected void ok_Click(object sender, EventArgs e)
        {
            //Taking whatever URL was created in the Domain method, and turning it into a string for another method.
            string str = Companyfinder.Domain(CompanyURL);  

            //Call to the JsonData method that uses the str string as its input
            Companyfinder.JsonData(str);

            //Creation of a new DataTable to organize and display my parsed jason data.
            DataTable orgtable = new DataTable();

            //Column was added in order to ensure the data table could be used.
            orgtable.Columns.Add("Company Data");

            
            ListBox1.DataSource = orgtable;
            ListBox1.DataTextField = "Company Data";

            //Every item in my orgData string array needs to be displayed in its own row once rendered.
            foreach(string s in Companyfinder.orgData)
            {
                orgtable.Rows.Add(s);
            }
            ListBox1.DataBind();

        }
    }
}