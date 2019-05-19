using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViaFitnessDataAccess.DataAccess;
using ViaFitnessDataAccess.Models;

namespace ViaFitnessDataAccess.BusinessLogic
{
    public class WorkoutProcessor
    {
        public static int CreateWorkout(string userId, string type, DateTime createDate)
        {


            WorkoutModel data = new WorkoutModel
            {
                UserId = userId,
                Type = type,
                CreateDate = createDate
            };

            string sql = @"INSERT INTO [dbo].[Workout] (UserId,Type, CreateDate) 
                            values (@UserId,@Type,@CreateDate);";

            return SQLDataAccess.ExecuteData(sql, data);
        }

        public static int DeleteWorkout(int id)
        {
            WorkoutModel data = new WorkoutModel
            {
                Id = id
            };

            string sql = @"DELETE FROM [dbo].[Workout] WHERE Id = @Id;";

            return SQLDataAccess.ExecuteData(sql, data);
        }

        public static List<WorkoutModel> GetWorkoutsByUserId(string userId)
        {
            WorkoutModel data = new WorkoutModel
            {
                UserId = userId
            };
            //SQLDataAccess.LoadData("dbo.spUse");
            string sql = @"SELECT Id, UserId, Type, CreateDate from [dbo].[Workout] WHERE UserId = @userId ;";

            return SQLDataAccess.LoadData(sql,data);
        }

        public static int UpdateWorkout(int id, string workoutType, DateTime createDate)
        {
            WorkoutModel data = new WorkoutModel
            {
                Id = id,
                Type = workoutType,
                CreateDate = createDate
            };

            string sql = @"UPDATE [dbo].[Workout] SET Type = @Type, CreateDate = @CreateDate
                            WHERE Id = @Id;";

            return SQLDataAccess.ExecuteData(sql, data);
        }
    }
}
