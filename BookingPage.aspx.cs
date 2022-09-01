using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
//using System.Windows.Forms;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.IO;
using System.Web.Helpers;
using System.Xml.Linq;
//using System.Windows.Forms;



namespace myproject
{
    public partial class BookingPage : System.Web.UI.Page
    {
        



        public string Label1 { get; private set; }



        protected void Page_Load(object sender, EventArgs e)
        {



        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter name')", true);
                // MessageBox.Show("");
            }
            else if (TextBox2.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter Movie name')", true);
            }
            else if (TextBox3.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter theatre')", true);
            }
            else if (TextBox4.Text == "")
            {
                //  MessageBox.Show("Enter password");
                ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Enter Timings')", true);
            }
            else
            {
                try
                {

                    int mobileno;
                    bool isParsable = Int32.TryParse(TextBox2.Text, out mobileno);
                    string constring = @"Data Source=172.16.12.14;Initial Catalog=Karthikaa;User id =training1;password=Karomi@123";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmd = new SqlCommand("Insert into bookticket values(name, mobileno, moviename, theatre, timings, seats) values(" +
                            "'" + mobileno + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "')", con))

                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@mobileno", mobileno);
                            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                            cmd.Parameters.AddWithValue("@moviename", TextBox2.Text);
                            cmd.Parameters.AddWithValue("@theatre", TextBox3.Text);
                            cmd.Parameters.AddWithValue("@timings", TextBox4.Text);
                            cmd.Parameters.AddWithValue("@seats", TextBox5.Text);
                            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    sda.Fill(dt);
                                    if (dt.Rows.Count >= 0)
                                    {
                                        ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('success')", true);
                                        Response.Redirect("~/WebForm4.aspx");
                                    }
                                    else
                                    {
                                        ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('not success')", true);
                                    }
                                }
                            }
                        }
                    }

                }
                //if (uploadresume() == true)
                //   {
                //string contenttypee = "application/pdf"

                catch (Exception)
                {
                    //   MessageBox.Show("Error");
                    ScriptManager.RegisterClientScriptBlock(Page, typeof(Page), "ClientScript", "alert('Ticket Booked')", true);
                }
            }
        }
    }
}