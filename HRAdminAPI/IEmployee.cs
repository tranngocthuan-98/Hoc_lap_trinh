namespace HRAdminAPI
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FristName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }
}
