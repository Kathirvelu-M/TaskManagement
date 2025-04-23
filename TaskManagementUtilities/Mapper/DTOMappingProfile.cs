using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementUtilities.DtoModels;

namespace TaskManagementUtilities.Mapper
{
    public class DTOMappingProfile : Profile
    {
        public DTOMappingProfile()
        {
            CreateMap<TaskManagementDataModels.Entities.Task, TaskDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TaskId))
                .ForMember(dest => dest.GridTaskNameVal, opt => opt.MapFrom(src => src.TaskName))
                .ForMember(dest => dest.GridAssigneeVal, opt => opt.MapFrom(src => src.Assignee)).ReverseMap();
        }
    }
}
