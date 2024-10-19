using Dependency_Injection.Services;

namespace Dependency_Injection.Managers
{
    public class ClassRoom
    {
        private readonly ITeacher _teacher;

        
        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();  
        }
    }
}
