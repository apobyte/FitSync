using FitSync.BLL._11.ExerciseSetsManagement.Dto;

namespace FitSync.BLL._11.ExerciseSetsManagement
{
    public interface IExerciseSetsBll
    {
        Task<bool> SyncExerciseSet(ExerciseSetsDto dto);
    }
}
