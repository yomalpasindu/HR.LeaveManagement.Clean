using AutoMapper;
using HR.LeaveManagement.Applicaation.Features.LeaveTypes.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Applicaation.MappingProfile
{
    public class LeaveTypeProfile:Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto,LeaveType>().ReverseMap();
        }
    }
}
