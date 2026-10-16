using FitSync.BLL._02.UserRelationManagement.Dto;
using FitSync.BLL._02.UsersManagement.Dto;
using FitSync.BLL._02.UsersVerificationManagement.Dto;
using FitSync.BLL._03.BodyMeasurementsManagement.Dto;
using FitSync.BLL._04.ExercisesManagement.Dto;
using FitSync.BLL._05.MuscleGroupsManagement.Dto;
using FitSync.BLL._06.ExerciseMuscleManagement.Dto;
using FitSync.BLL._07.RoutineRequestManagement.Dto;
using FitSync.BLL._07.RoutinesManagement.Dto;
using FitSync.BLL._08.RoutineExercisesManagement.Dto;
using FitSync.BLL._09.WorkoutSessionsManagement.Dto;
using FitSync.BLL._10.WorkoutExercisesManagement.Dto;
using FitSync.BLL._11.ExerciseSetsManagement.Dto;
using FitSync.BLL._12.FeedEventManagement.Dto;
using System.Text.Json.Serialization;

namespace FitSync.BLL._0.Sync.Dto
{
    public class SyncPayloadDto
    {
        [JsonPropertyName("token")]
        public string? Token { get; set; } = string.Empty;

        [JsonPropertyName("users")]
        public List<UserReadDto> Users { get; set; } = new();

        [JsonPropertyName("userRelations")]
        public List<UserRelationDto> UserRelations { get; set; } = new();

        [JsonPropertyName("userInvitations")]
        public List<UsersInvitationDto> UserInvitations { get; set; } = new();

        [JsonPropertyName("bodyMeasurements")]
        public List<BodyMeasurementsDto> BodyMeasurements { get; set; } = new();

        [JsonPropertyName("exercises")]
        public List<ExercisesDto> Exercises { get; set; } = new();

        [JsonPropertyName("muscleGroups")]
        public List<MuscleGroupDto> MuscleGroups { get; set; } = new();

        [JsonPropertyName("exerciseMuscleGroups")]
        public List<ExerciseMuscleDto> ExerciseMuscleGroups { get; set; } = new();

        [JsonPropertyName("routines")]
        public List<RoutineDto> Routines { get; set; } = new();

        [JsonPropertyName("routineRequests")]
        public List<RoutineRequestDto> RoutinesRequests { get; set; } = new();

        [JsonPropertyName("routineExercises")]
        public List<RoutineExerciseDto> RoutineExercises { get; set; } = new();

        [JsonPropertyName("workoutSessions")]
        public List<WorkoutSessionsDto> WorkoutSessions { get; set; } = new();

        [JsonPropertyName("workoutExercises")]
        public List<WorkoutExercisesDto> WorkoutExercises { get; set; } = new();

        [JsonPropertyName("exerciseSets")]
        public List<ExerciseSetsDto> ExerciseSets { get; set; } = new();

        [JsonPropertyName("feedEvents")]
        public List<FeedEventDto> FeedEvents { get; set; } = new();
    }
}
