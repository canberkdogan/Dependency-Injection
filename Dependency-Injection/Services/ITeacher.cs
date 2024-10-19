namespace Dependency_Injection.Services
{
    public interface ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        string GetInfo();

    }
}
