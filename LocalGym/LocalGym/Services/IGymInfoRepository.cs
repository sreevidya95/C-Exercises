using LocalGym.Models;

namespace LocalGym.Services
{
    public interface IGymInfoRepository
    {
        Task<IEnumerable<Member>> GetMembersAsync();
        Task<Member> GetMemberByIdAsync(int id);
        Task<IEnumerable<Trainer>> GetTrainersAsync();
        Task<Trainer?> GetTrainerByIdAsync(int id);
         Task CreateTask(Trainer trainer);
         Task<bool> saveChages();
        Task UpdateTask(Trainer trainer);
        Task<IEnumerable<Session>> GetSessionByTrainerIdAsync(int id);
        Task<IEnumerable<Session>> GetSessionByMemberIdAsync(int id);
    }

}
