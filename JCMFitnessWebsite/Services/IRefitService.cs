using JCMFitnessPostgresAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCMFitnessWebsite.Services
{
    public interface IRefitService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(string id);

        Task<IEnumerable<Workout>> GetUserWorkouts(string id);
        Task CreateUserWorkout(string userID, string workoutID);
    }
}
