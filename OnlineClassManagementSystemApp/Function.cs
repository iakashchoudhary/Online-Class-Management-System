using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineClassManagementSystemApp
{
    public class Function
    {
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itsak\source\repos\AWPMiniProject\OnlineClassManagementSystemApp\OnlineClassManagementSystemApp\OCMSdatabase.mdf;Integrated Security=True";
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dt;

        public string GetMessage
        {
            get;
            set;
        }

        public Function()
        {
            sqlCommand = new SqlCommand();
            sqlConnection = new SqlConnection(ConnectionString);
            sqlDataAdapter = new SqlDataAdapter();
            dt = new DataTable();
        }

        public bool connected()
        {
            try
            {
                sqlConnection.Open();
                GetMessage = "Connected Successfully";
                return true;
            }
            catch (Exception ex)
            {
                GetMessage = "Connection Failed!!" + ex.Message;
                return false;
            }
        }

        public bool disconnected()
        {
            try
            {
                sqlConnection.Close();
                GetMessage = "Disconnected Successfully";
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public String Insert(string Query)
        {
            string Message = null;
            string allQueries = Query.ToUpper();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = Query.ToUpper();
                connected();
                sqlCommand.ExecuteNonQuery();
                if(allQueries.ToUpper().Contains("INSERT INTO"))
                {
                    Message = GetMessage = ("Inserted Successfully");
                }
            }
            catch (Exception ex)
            {
                Message = GetMessage = "Fail to Execute" + Query + "\nReason: " + ex.Message;
            }
            finally
            {
                disconnected();
            }
            return Message;
        }

        public String Update(string Query)
        {
            string Message = null;
            string allQueries = Query.ToUpper();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = Query.ToUpper();
                connected();
                sqlCommand.ExecuteNonQuery();
                if (allQueries.ToUpper().Contains("UPDATE") && allQueries.ToUpper().Contains("SET"))
                {
                    Message = GetMessage = ("Updated Successfully");
                }
            }
            catch (Exception ex)
            {
                Message = GetMessage = "Fail to Execute" + Query + "\nReason: " + ex.Message;
            }
            finally
            {
                disconnected();
            }
            return Message;
        }

        public String Delete(string Query)
        {
            string Message = null;
            string allQueries = Query.ToUpper();
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = Query.ToUpper();
                connected();
                sqlCommand.ExecuteNonQuery();
                if (allQueries.ToUpper().Contains("DELETE"))
                {
                    Message = GetMessage = ("Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                Message = GetMessage = "Fail to Execute" + Query + "\nReason: " + ex.Message;
            }
            finally
            {
                disconnected();
            }
            return Message;
        }

        public string FillGridView(string Query, DataGridView dataGridView)
        {
            dt = new DataTable();
            string Message;
            try
            {
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = Query;
                connected();
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dt);
                dataGridView.DataSource = dt;
                Message = "Code Executed Successfully";
            }
            catch (Exception)
            {
                Message = "Fail to Execute!!";
            }
            finally
            {
                disconnected();
                dt = null;
            }
            return Message;
        }
    }
}
