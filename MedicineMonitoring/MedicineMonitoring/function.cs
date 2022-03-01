using System;
using System.Data.SqlClient;
using System.Data;

namespace Medisys
{ // after admin dashboard  1:46:10 timestamp
	class function()
	{// CONNECTION STRING
	protected SqlConnection Getconnection()
	{
		SqlConnection con = new SqlConnection();
		con.ConnectionString = "data source=LAPTOP-5VD4LSFK;database=Medisys;integrated security=True";// dataSource of everyones laptop will be different .

		return con;
	}
	//
	public DataSet GetData(string query)
	{
		SqlConnection con = Getconnection();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = con;
		cmd.CommandText = query;
		SqlDataAdapter da = new SqlDataAdapter(cmd);
		DataSet ds = new DataSet();
		ds.Fill(ds);
		return ds;	
	}
	// 
	public void setData(string query, string msg)
	{
		SqlConnection con = Getconnection();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = con;
		con.Open();
		cmd.CommandText = query;
		cmd.ExecuteNonQuery();
		con.Close();
		MessageBox.Show(msg,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

	}

	// in public partial class of UC_AddUsers.cs
	 function fn = new function();
	  String query; 
	*/





	//after this we have to assign action to btn signup of UC_ADDUSER.cs  ( 2:01:42 )
	  // adding a new user , we need these details
	  // in btnSignUp_Click in UC_ADDUSER.cs file
	  
		//code

      String role = txtUserRole.Text;
	  String f_Name = txtfName.Text; // first name
	  String l_Name = txtlName.Text;     // last name 
	  String dob = txtDob.Text;
	  String gender = txtDob.Text;
	  Int64 mobile = Int64.Parse(txtMobile.Text);
	  String email = txtEmail.Text;
	
	  String username = txtUsername.Text;
	  String pass = txtPassword.Text;
	  
	  try 
	  {
	    query = " insert into users (userRole,f_Name,l_Name,dob,gender,mobile,email,username,pass) values ('"+role+"','"+f_Name+"','"+l_Name+"','"+dob+"','"+gender+"','"+mobile+"','"+email+"','"+username+"','"+pass+"',)
	    fn.setData(query,"Your Details are submitted Successfully")
	  }
	  catch
	  {
	    MessageBox.Show("Username already Exist.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
	  }
	   ///////
     NOW FOR THE RESET BUTTON btnReset_Click
	{
	   clearAll();
	  
	
	}
	public void clearALL()
	{
	  txtfName.Clear();
	  txtlName.Clear();
	  txtdob.ResetText();
	  txtgender.Clear();
	  txtMobileno.Clear();
	  txtEmail.Clear();
	  txtUsername.Clear();
	  txtPassword.Clear();
	  txtUserRole.SelectedIndex =-1;
	  
	}


	 
}
}
