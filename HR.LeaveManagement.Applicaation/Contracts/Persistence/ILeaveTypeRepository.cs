using HR.LeaveManagement.Domain;

namespace HR.LeaveManagement.Applicaation.Contracts.Persistence
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<bool> IsLeaveTypeUnique(string name);
    }
}
