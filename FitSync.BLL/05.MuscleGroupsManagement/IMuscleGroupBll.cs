using FitSync.BLL._05.MuscleGroupsManagement.Dto;

namespace FitSync.BLL._05.MuscleGroupsManagement
{
    public interface IMuscleGroupBll
    {
        Task<bool> SyncMuscleGroup(MuscleGroupDto muscleGroupDto);
    }
}
