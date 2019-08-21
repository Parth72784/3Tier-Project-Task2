using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

using BussinessObject;

namespace DataAccess
{
    public class UserDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ToString());
        public int AddUserDetails(UserBO ObjBO) // passing Bussiness object Here  
        {
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx) To in Bussiness object and then Pass it to Bussiness logic and then to DataAcess  this way the flow carry on*/
                SqlCommand cmd = new SqlCommand("insert into Userinfo (Name,Address,EmailID,Mobilenumber)values(@Name,@Address,@EmailID,@Mobilenumber)", con);
                
                cmd.Parameters.AddWithValue("@Name", ObjBO.Name);
                cmd.Parameters.AddWithValue("@Address", ObjBO.address);
                cmd.Parameters.AddWithValue("@EmailID", ObjBO.EmailID);
                cmd.Parameters.AddWithValue("@Mobilenumber", ObjBO.Mobilenumber);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;
            }
            catch
            {
                throw;
            }
        }
    }
}  
    

