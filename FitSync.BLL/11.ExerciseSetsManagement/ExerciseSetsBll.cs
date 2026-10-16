using AutoMapper;
using Microsoft.EntityFrameworkCore;
using FitSync.BLL._11.ExerciseSetsManagement.Dto;
using FitSync.DAL._1.Entity;
using FitSync.DAL._2.Context;

namespace FitSync.BLL._11.ExerciseSetsManagement
{
    public class ExerciseSetsBll : IExerciseSetsBll
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly FitSyncDbContext _context;
        #endregion


        #region Constructors
        public ExerciseSetsBll(FitSyncDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion


        #region Methods
        public async Task<bool> SyncExerciseSet(ExerciseSetsDto dto)
        {
            var existing = await _context.ExerciseSets
                .FirstOrDefaultAsync(s => s.Id == dto.Id ||
                                         (s.WorkoutExerciseId == dto.WorkoutExerciseId &&
                                          s.SetNumber == dto.SetNumber));

            if (existing == null)
            {
                var entity = _mapper.Map<ExerciseSets>(dto);
                await _context.ExerciseSets.AddAsync(entity);
            }
            else
            {
                var existingId = existing.Id;
                if (existing.DeletedAt != null && dto.DeletedAt == null)
                {
                    existing.DeletedAt = null;
                }

                if (dto.UpdatedAt > existing.UpdatedAt || existing.UpdatedAt == null)
                {
                    _mapper.Map(dto, existing);
                    existing.Id = existingId;
                    _context.ExerciseSets.Update(existing);
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