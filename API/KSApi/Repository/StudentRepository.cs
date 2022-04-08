using KSApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSApi.Repository
{
    public interface IStudentRepository
    {
        Task<Student> Get(int id);
        Task<IEnumerable<Student>> GetAll();
        Task<int> Add(Student entity);
        Task<bool> Delete(int id);
        Task<bool> Update(Student studentEntity);
    }
}
