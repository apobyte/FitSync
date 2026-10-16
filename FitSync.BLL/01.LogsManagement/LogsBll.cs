using FitSync.DAL._1.Entity;
using FitSync.DAL._2.Context;

namespace FitSync.BLL._01.LogsManagement
{
    public class LogsBll : ILogsBll
    {
        #region Fields
        private readonly FitSyncDbContext _context;
        #endregion


        #region Constructors
        public LogsBll(FitSyncDbContext context)
        {
            _context = context;
        }
        #endregion


        #region Methods
        public async Task<bool> CreateLogAsync(Guid userId, string type)
        {
            var log = new Logs
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                Type = type,
                CreatedAt = DateTime.UtcNow
            };
            _context.Logs.Add(log);
            return (await _context.SaveChangesAsync()) > 0;
        }
        #endregion
    }
}
