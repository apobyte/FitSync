using AutoMapper;
using Microsoft.EntityFrameworkCore;
using FitSync.BLL._08.RoutineExercisesManagement.Dto;
using FitSync.DAL._1.Entity;
using FitSync.DAL._2.Context;

namespace FitSync.BLL._08.RoutineExercisesManagement
{
    public class RoutineExercisesBll : IRoutineExercisesBll
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly FitSyncDbContext _context;
        #endregion


        #region Constructors
        public RoutineExercisesBll(FitSyncDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion


        #region Methods
        public async Task<bool> SyncRoutineExercise(RoutineExerciseDto dto)
        {
            var existing = await _context.RoutineExercises
                .FirstOrDefaultAsync(re => re.Id == dto.Id ||
                                          (re.RoutineId == dto.RoutineId &&
                                           re.ExerciseId == dto.ExerciseId &&
                                           re.Order == dto.Order));

            if (existing == null)
            {
                var entity = _mapper.Map<RoutineExercises>(dto);
                await _context.RoutineExercises.AddAsync(entity);
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
                    _context.RoutineExercises.Update(existing);
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