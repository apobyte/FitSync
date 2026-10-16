using FitSync.BLL._06.ExerciseMuscleManagement.Dto;

namespace FitSync.BLL._06.ExerciseMuscleManagement
{
    public interface IExerciseMuscleGroupBll
    {
        Task<bool> SyncExerciseMuscleGroup(ExerciseMuscleDto dto);
    }
}
