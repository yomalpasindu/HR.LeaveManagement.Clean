using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Applicaation.Features.LeaveTypes.Queries.GetLeaveTypesDetails
{
    public record GetLeaveTypesDetailsQuery(int Id):IRequest<LeaveTypesDetailsDto>;
}
