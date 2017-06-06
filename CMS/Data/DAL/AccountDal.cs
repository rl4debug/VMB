using System;
using CMS.Models.DataModels;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace CMS.Data.DAL
{
    public class AccountDal : BaseDal
    {
        public LoginModel Login(LoginParamModel model)
        {
			var errMessage = "";
			var connection = new SqlConnection(ConnectionString);
            try
            {
                var p = new DynamicParameters();
                p.Add("username", model.Username);
                p.Add("password", model.Password);
                p.Add("ErrMsg", direction: ParameterDirection.Output, dbType: DbType.String, size: 500);
                var infos = connection.Query<MemberInfo>("Login", param: p, commandType: CommandType.StoredProcedure);
                errMessage = p.Get<string>("ErrMsg");

                if (!string.IsNullOrEmpty(errMessage))
                {
                    return new LoginModel
                    {
                        ErrorMessage = errMessage
                    };
                }
                else return new LoginModel
                {
                    ErrorMessage = errMessage,
                    MemberInfo = infos.Single()
				};
			}
			catch (Exception ex)
			{
				errMessage = ex.Message;
				return new LoginModel
				{
					ErrorMessage = errMessage
				};
			}
			finally
			{
				connection.Close();
				connection.Dispose();
			}
        }
    }
}
