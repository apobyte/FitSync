using AutoMapper;
using FitSync.BLL._02.UserRelationManagement.Dto;
using FitSync.BLL._02.UsersManagement;
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
using FitSync.DAL._1.Entity;

namespace FitSync.BLL._0.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Users, UserReadDto>().ReverseMap();
            CreateMap<UserDto, Users>();
            CreateMap<UsersRelations, UserRelationDto>().ReverseMap();
            CreateMap<UsersInvitations, UsersInvitationDto>().ReverseMap();
            CreateMap<BodyMeasurements, BodyMeasurementsDto>().ReverseMap();
            CreateMap<Exercise, ExercisesDto>().ReverseMap();
            CreateMap<MuscleGroup, MuscleGroupDto>().ReverseMap();
            CreateMap<ExerciseMuscleGroup, ExerciseMuscleDto>().ReverseMap();
            CreateMap<Routines, RoutineDto>().ReverseMap();
            CreateMap<RoutineRequests, RoutineRequestDto>().ReverseMap();
            CreateMap<RoutineExercises, RoutineExerciseDto>().ReverseMap();
            CreateMap<WorkoutSessions, WorkoutSessionsDto>().ReverseMap();
            CreateMap<WorkoutExercises, WorkoutExercisesDto>().ReverseMap();
            CreateMap<ExerciseSets, ExerciseSetsDto>().ReverseMap();
            CreateMap<FeedEvent, FeedEventDto>().ReverseMap();
        }
    }
}
