using FitSync.BLL._10.WorkoutExercisesManagement.Dto;

namespace FitSync.BLL._10.WorkoutExercisesManagement
{
    public interface IWorkoutExercisesBll
    {
        Task<bool> SyncWorkoutExercise(WorkoutExercisesDto dto);
    }
}
