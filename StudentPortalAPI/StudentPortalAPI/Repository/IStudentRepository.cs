using StudentPortalAPI.DataModels;

namespace StudentPortalAPI.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
    }
}
