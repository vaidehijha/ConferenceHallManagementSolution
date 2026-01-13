using DAL_ConferenceHallManagement.DbContexts;
using Models_ConferenceHallManagement.AppDbModels;
using Microsoft.EntityFrameworkCore;

namespace Repository_ConferenceHallManagement.AppDataRepositoy
{
    public interface IConferenceHallDataRepository : IRepository<ConferenceHall>
    {
        Task<bool> CreateHallWithSessionsAsync(ConferenceHall hall);
    }

    public class ConferenceHallDataRepository : Repository<ConferenceHall>, IConferenceHallDataRepository
    {
        private readonly ConferenceHallManagementContext _appContext;

        public ConferenceHallDataRepository(ConferenceHallManagementContext context) : base(context)
        {
            _appContext = context;
        }

        public async Task<bool> CreateHallWithSessionsAsync(ConferenceHall hall)
        {
            try
            {
                // Check if there's already an active transaction
                var existingTransaction = _appContext.Database.CurrentTransaction;
                
                if (existingTransaction != null)
                {
                    // Work within the existing transaction
                    await _appContext.ConferenceHalls.AddAsync(hall);
                    await _appContext.SaveChangesAsync();
                    return true;
                }

                // Only start a new transaction if one doesn't exist
                using var transaction = await _appContext.Database.BeginTransactionAsync();
                try
                {
                    await _appContext.ConferenceHalls.AddAsync(hall);
                    await _appContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return true;
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
            catch (Exception ex)
            {
                // Optional: Log the exception 'ex' here
                return false;
            }
        }
    }
}