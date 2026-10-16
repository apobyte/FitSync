using FitSync.BLL._07.RoutinesManagement.Dto;

namespace FitSync.BLL._07.RoutinesManagement
{
    public interface IRoutineBll
    {
        Task<bool> SyncRoutine(RoutineDto routineDto);
        Task<bool> CloneRoutineForUserAsync(Guid routineId, Guid userId);
    }
}
