using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;

namespace EmployeeManagement.DataAccess
{
    class DataBaseHelper : DataAccessBase
    {
        public SqlParameter[] Parameters { get; set; }
        public DataBaseHelper(string storedProcedureName)
        {
            StoredProcedureName = storedProcedureName;
        }
        //public void ExcecuteQuery(SqlTransaction transaction)
        //{
        //    SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, StoredProcedureName, Parameters);
        //}
        //public void ExcecuteQuery(SqlTransaction transaction, SqlParameter[] parameters)
        //{
        //    SqlHelper.ExecuteNonQuery(transaction,
        //                              CommandType.StoredProcedure,
        //                              StoredProcedureName,
        //                              parameters);
        //}
        public DataSet ExcecuteQuery(string connectionstring, SqlParameter[] parameters)
        {
            DataSet dataSetObjct;
            dataSetObjct = SqlHelper.ExecuteDataset(connectionstring, StoredProcedureName, parameters);
            return dataSetObjct;
        }
        public int ExcecuteQuery()
        {
            return SqlHelper.ExecuteNonQuery(base.ConnectionString,
                                      CommandType.StoredProcedure,
                                      StoredProcedureName,
                                      Parameters);
        }

        public SqlDataReader ExcecuteQuery(SqlParameter[] parameters)
        {
            SqlDataReader dataReaderObject;
            dataReaderObject = SqlHelper.ExecuteReader(base.ConnectionString,
                                        CommandType.StoredProcedure,
                                        StoredProcedureName,
                                        parameters);
            return dataReaderObject;
        }
        public object ExcecuteScalarQuery(SqlTransaction transaction, SqlParameter[] parameters)
        {
            return SqlHelper.ExecuteScalar(transaction, StoredProcedureName, parameters);
        }

    }
}
