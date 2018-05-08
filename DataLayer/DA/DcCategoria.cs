using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using EntitiesLayer;

namespace DataLayer.DA
{
    public class DcCategoria
    {
        public DataSet ReadAll()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["ConnDaniel2"].ConnectionString;
            OracleConnection oraCon = new OracleConnection(strConnection);
            OracleCommand oraCmd = new OracleCommand();
            oraCmd.Connection = oraCon;
            DataSet ds = new DataSet();
            try
            {
                oraCon.Open();
                OracleDataAdapter DA = new OracleDataAdapter(@"SELECT * FROM CATEGORIA", oraCon);

                DataSet DS = new DataSet();
                DA.Fill(DS);
                return DS;
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
            finally
            { if (oraCon.State == ConnectionState.Open) oraCon.Close(); oraCmd.Dispose(); }
        }

    }
}
