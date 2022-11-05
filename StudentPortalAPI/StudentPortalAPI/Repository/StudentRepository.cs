using Microsoft.EntityFrameworkCore;
using StudentPortalAPI.DataModels;

namespace StudentPortalAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _dbcontext;

        public StudentRepository(StudentAdminContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _dbcontext.Student.Include(nameof(Address)).ToListAsync();
        }
    }
}
