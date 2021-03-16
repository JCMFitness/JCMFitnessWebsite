using JCMFitnessPostgresAPI.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JCMFitnessWebsite.Services
{
    public class RefitService : IRefitService
    {
        private readonly IRefitApi _refitApi;
        //private string azureCode;

        public RefitService(IRefitApi refitApi)
        {
            this._refitApi = refitApi;
           // azureCode = Settings.apiKey;
        }

        public async Task<List<User>> GetUsers()
        {
            try
            {
                return await _refitApi.GetUsersAsync();
            }
            catch (Exception ex)
            {
                throw;

            }
        }
        public async Task<User> GetUserById(string id)
        {
            try
            {
                return await _refitApi.GetUserByIdAsync(id);
            }
            catch (Exception ex)
            {
                throw;

            }
        }

        public async Task<IEnumerable<Workout>> GetUserWorkouts(string id)
        {
            try
            {
                return await _refitApi.GetUserWorkoutsAsync(id);
            }
            catch (Exception ex)
            {
                throw;

            }
        }

        public async Task CreateUserWorkout (string userID, string workoutID)
        {
            try
            {
                await _refitApi.CreateUserWorkoutAsync(userID, workoutID);
            }
            catch (Exception ex)
            {
                throw;

            }
        }


    }

    public interface IRefitApi
    {
        [Get("/api/user")]
        public Task<List<User>> GetUsersAsync();

        [Get("/api/user/{userid}")]
        public Task<User> GetUserByIdAsync(string userid);

        [Get("/api/userworkouts/{userid}")]
        public Task<IEnumerable<Workout>> GetUserWorkoutsAsync(string userid);

        [Post("/api/userworkouts/{userid}{workoutid}")]
        public Task CreateUserWorkoutAsync(string userid, string workoutid);
    }
}
