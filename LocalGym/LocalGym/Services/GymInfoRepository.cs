using LocalGym.GymDbContext;
using LocalGym.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Runtime.CompilerServices;

namespace LocalGym.Services
{
    public class GymRepository : IGymInfoRepository
    {
        private GymInfo gymInfo;

        public GymRepository(GymInfo gymInfo) { 

            this.gymInfo = gymInfo;
        }

        public async Task<Member> GetMemberByIdAsync(int id) {
            return await gymInfo.Members.FirstOrDefaultAsync();
            }

        public async Task<IEnumerable<Member>> GetMembersAsync()
        {
            return await gymInfo.Members.OrderBy(x=>x.First_name).ToListAsync();
        }

        public async Task<IEnumerable<Session>> GetSessionByMemberIdAsync(int id)
        {
            return await gymInfo.Sessions.Where(x => x.MemberId == id).ToListAsync();
        }

        public async Task<IEnumerable<Session>> GetSessionByTrainerIdAsync(int id)
        {
            return await gymInfo.Sessions.Where(x=>x.TrainerId == id).ToListAsync();
        }

        public async Task CreateTask(Trainer trainer)
        {
             gymInfo.Add(trainer);      
                
         }
        public async Task UpdateTask(Trainer trainer)
        {
            gymInfo.Update(trainer);
        }
        public async Task<bool>saveChages()
        {
            return (await gymInfo.SaveChangesAsync()>0);
        }

        async Task<Trainer?> IGymInfoRepository.GetTrainerByIdAsync(int id)
        {
            return await gymInfo.Trainers.FirstOrDefaultAsync(x=>x.TrainerId==id);
        }

        async Task<IEnumerable<Trainer>> IGymInfoRepository.GetTrainersAsync()
        {
           return await gymInfo.Trainers.OrderBy(x=>x.FirstName).ToListAsync();
        }
    }
}
