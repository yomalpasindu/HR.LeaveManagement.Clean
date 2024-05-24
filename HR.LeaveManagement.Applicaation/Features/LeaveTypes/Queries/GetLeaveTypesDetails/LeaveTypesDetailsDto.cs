namespace HR.LeaveManagement.Applicaation.Features.LeaveTypes.Queries.GetLeaveTypesDetails
{
    public class LeaveTypesDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}