namespace HRAdminAPI
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public virtual decimal Salary { get; set; }
    }
}
