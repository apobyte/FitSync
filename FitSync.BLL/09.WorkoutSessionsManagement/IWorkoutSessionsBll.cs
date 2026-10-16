using FitSync.BLL._09.WorkoutSessionsManagement.Dto;

namespace FitSync.BLL._09.WorkoutSessionsManagement
{
    public interface IWorkoutSessionsBll
    {
        Task<bool> SyncWorkoutSession(WorkoutSessionsDto dto);
    }
}
