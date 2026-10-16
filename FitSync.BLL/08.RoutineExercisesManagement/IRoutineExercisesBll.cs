using FitSync.BLL._08.RoutineExercisesManagement.Dto;

namespace FitSync.BLL._08.RoutineExercisesManagement
{
    public interface IRoutineExercisesBll
    {
        Task<bool> SyncRoutineExercise(RoutineExerciseDto dto);
    }
}
