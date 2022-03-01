using System;
using System.Data.SqlClient;
using System.Data;

namespace Medisys
{
	class function()
	{// CONNECTION STRING
	protected SqlConnection Getconnection()
	{
		SqlConnection con = new SqlConnection();
		con.ConnectionString = "data source=LAPTOP-5VD4LSFK;database=Medisys;integrated security=True";

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

		
	}
}
