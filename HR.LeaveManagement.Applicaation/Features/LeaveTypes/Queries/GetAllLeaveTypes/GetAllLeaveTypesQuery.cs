using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Applicaation.Features.LeaveTypes.Queries.GetAllLeaveTypes
{
    //public class GetAllLeaveTypesQuery : IRequest<List<LeaveTypeDto>>
    //{

    //}
    public record GetAllLeaveTypesQuery:IRequest<List<LeaveTypeDto>>;
}
