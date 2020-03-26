using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace ASCT_Razor_Page.Models
{
    public class db
    {
        SqlConnection con;
        public db() 
        {
            var configuration = GetConfiguration();
            con = new SqlConnection(configuration.GetSection("Data").GetSection("ConnectionString").Value);
        }

        public string GetRecord(Aircraft unit)
        {
            try
            {
                SqlCommand com = new SqlCommand("Add_Aircraft", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TailNumber", unit.Tail_Number);
                com.Parameters.AddWithValue("@LRUName", unit.LRU_Name);
                com.Parameters.AddWithValue("@LRUPartNumber", unit.LRU_Part_Number);
                com.Parameters.AddWithValue("@SoftwareName", unit.Software_Name);
                com.Parameters.AddWithValue("@SoftwarePartNumber", unit.Software_Part_Number);
                com.Parameters.AddWithValue("@ECNumber", unit.EC_Number);
                com.Parameters.AddWithValue("@PrePostCondition", unit.Pre_Post_Condition);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return ex.Message.ToString();
            }

        }

        public string InsertRecord(Aircraft unit) 
        {
            try
            {
                /*                string sql = @"insert into dbo.Aircrafts (TailNumber, LRUName, 
                                                LRUPartNumber, SoftwareName, SoftwraePartNumber, 
                                                ECNumber, PrePostCondtion)
                                                values (unit.Tail_Number, unit.LRU_Name, 
                                                unit.LRU_Part_Number, unit.Software_Name,
                                                unit.Software_Part_Number, unit.EC_Number, unit.Pre_Post_Condition);";
                                return SqlDataAccess.SaveData(sql, unit);*/
                SqlCommand com = new SqlCommand("Add_Aircraft", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TailNumber", unit.Tail_Number);
                com.Parameters.AddWithValue("@LRUName", unit.LRU_Name);
                com.Parameters.AddWithValue("@LRUPartNumber", unit.LRU_Part_Number);
                com.Parameters.AddWithValue("@SoftwareName", unit.Software_Name);
                com.Parameters.AddWithValue("@SoftwarePartNumber", unit.Software_Part_Number);
                com.Parameters.AddWithValue("@ECNumber", unit.EC_Number);
                com.Parameters.AddWithValue("@PrePostCondition", unit.Pre_Post_Condition);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return "OK";

            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open) 
                {
                    con.Close();
                }
                return ex.Message.ToString();
            }

        }
        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
