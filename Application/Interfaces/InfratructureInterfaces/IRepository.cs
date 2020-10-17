using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.InfratructureInterfaces
{
    public  interface IRepository
    {
        // Load
        Task<Domain.Entities.Teacher> Load_Teacher(Guid id);
        Task<Domain.Entities.Student> Load_Student(Guid id);
        Task<IEnumerable> GetAll_Students();



        // Save
        Task Save_Teacher(Domain.Entities.Teacher teacher);
        Task Save_Student(Domain.Entities.Student student);



        // Delete
        Task Delete_Teacher(Domain.Entities.Teacher teacher);
        Task Delete_Student(Domain.Entities.Student student); 
    }
}
