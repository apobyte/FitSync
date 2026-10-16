using FitSync.BLL._07.RoutineRequestManagement.Dto;

namespace FitSync.BLL._07.RoutineRequestManagement
{
    public interface IRoutineRequestBll
    {
        Task<bool> SyncRoutineRequest(RoutineRequestDto dto);
    }
}
