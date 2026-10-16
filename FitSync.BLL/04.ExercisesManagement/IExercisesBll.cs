using FitSync.BLL._04.ExercisesManagement.Dto;

namespace FitSync.BLL._04.ExercisesManagement
{
    public interface IExercisesBll
    {
        Task<bool> SyncExercise(ExercisesDto exerciseDto);
    }
}
