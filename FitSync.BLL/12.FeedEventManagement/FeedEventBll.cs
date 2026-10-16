using AutoMapper;
using Microsoft.EntityFrameworkCore;
using FitSync.BLL._12.FeedEventManagement.Dto;
using FitSync.DAL._1.Entity;
using FitSync.DAL._2.Context;

namespace FitSync.BLL._12.FeedEventManagement
{
    public class FeedEventBll : IFeedEventBll
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly FitSyncDbContext _context;
        #endregion

        #region Constructors
        public FeedEventBll(FitSyncDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<bool> SyncFeedEvent(FeedEventDto dto)
        {
            var existing = await _context.FeedEvents.FirstOrDefaultAsync(fe => fe.Id == dto.Id);

            if (existing == null)
            {
                var entity = _mapper.Map<FeedEvent>(dto);
                entity.UpdatedAt = DateTime.UtcNow;
                await _context.FeedEvents.AddAsync(entity);
            }
            else
            {
                if (existing.DeletedAt != null && dto.DeletedAt == null)
                {
                    existing.DeletedAt = null;
                }

                if (dto.UpdatedAt > existing.UpdatedAt || existing.UpdatedAt == null)
                {
                    _mapper.Map(dto, existing);
                    _context.FeedEvents.Update(existing);
                }
                else
                {
                    return true;
                }
            }
            return await _context.SaveChangesAsync() > 0;
        }
        #endregion
    }
}