using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaFitnessDataAccess.DataAccess;
using ViaFitnessDataAccess.Models;

namespace ViaFitnessDataAccess.BusinessLogic
{
    public class UserProcessor
    {

        public static int CreateUser(string id, string firstName, string lastName, string emailAddress)
        {
            UserModel data = new UserModel
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"INSERT INTO [dbo].[User] (Id,FirstName,LastName,EmailAddress) 
                            values (@Id,@FirstName,@LastName,@EmailAddress);";

            return SQLDataAccess.ExecuteData(sql, data);
        }

        public static UserModel GetUserById(string id)
        {
            UserModel data = new UserModel
            {
                Id = id
            };
            //command.Parameters.Add("@Id", SqlDbType.Int32).Value = Id;

            //SQLDataAccess.LoadData("dbo.spUse");
            string sql = @"SELECT Id, FirstName, LastName, EmailAddress from [dbo].[User] WHERE Id = @Id ;";

            return SQLDataAccess.LoadData(sql,data).FirstOrDefault();
        }

        public static UserModel GetByEmail(string emailAddress)
        {
            UserModel data = new UserModel
            {
                EmailAddress = emailAddress
            };
            string sql = @"SELECT Id, FirstName, LastName, EmailAddress from [dbo].[User] WHERE EmailAddress = @emailAddress ;";

            return SQLDataAccess.LoadData(sql,data).FirstOrDefault();
        }

        public static List<UserModel> LoadUser()
        {
            string sql = @"SELECT Id, FirstName, LastName, EmailAddress from [dbo].[User];";

            return SQLDataAccess.LoadData<UserModel>(sql,null);
        }
    }
}
