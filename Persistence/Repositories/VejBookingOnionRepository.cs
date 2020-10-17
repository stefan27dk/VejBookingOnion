using Application.Interfaces.InfratructureInterfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class VejBookingOnionRepository : IRepository
    {


        // Db Context
        private readonly VejBookingOnionDbContext _DbContext; 




        // Constructor
        public VejBookingOnionRepository(VejBookingOnionDbContext DbContext)
        {
            _DbContext = DbContext;
        }





        // ::Delete::----------------------------------------------------------------------------------------------------------

        // Delete Student
        async Task IRepository.Delete_Student(Student student)
        {
            var found = await _DbContext.Students.FirstOrDefaultAsync(a => a.Id == student.Id); // Get Student
            if(found == null) { throw new Exception($"Student with ID = {student.Id} Not Found"); } // If Not found Exception

            _DbContext.Students.Remove(found);  // If found Remove
            await _DbContext.SaveChangesAsync(); // Save Changes
        }



        // Delete Teacher   
        async Task IRepository.Delete_Teacher(Teacher teacher)
        {
            var found = await _DbContext.Teachers.FirstOrDefaultAsync(a => a.Id == teacher.Id); // Get
            if (found == null) { throw new Exception($"Teacher with ID = {teacher.Id} Not Found"); } // If Not found Exception

            _DbContext.Teachers.Remove(found);
            await _DbContext.SaveChangesAsync();         
        }






        // ::Load::----------------------------------------------------------------------------------------------------------   
        //Load Student
        async Task<Student> IRepository.Load_Student(Guid id)
        {
            var found = await _DbContext.Students.FirstOrDefaultAsync(a => a.Id == id);
            if(found == null) { throw new Exception($"Student with ID = {id} Not Found"); } // If Not found Exception


            return found;
        }





        // Get All Students
        async Task<IEnumerable> IRepository.GetAll_Students()
        {
            var found = await _DbContext.Students.ToListAsync();
            if(found == null)
            {
                throw new Exception($"Cant Get All Students - List is null");
            }

            return found;
        }




        //Load Teacher
        async Task<Teacher> IRepository.Load_Teacher(Guid id)
        {
            var found = await _DbContext.Teachers.FirstOrDefaultAsync(a => a.Id == id);
            if (found == null) { throw new Exception($"Teacher with ID = {id} Not Found"); } // If Not found Exception

            return found;
        }




         //::SAVE::---------------------------------------------------------------------------------------------------

        // Save Student
        async Task IRepository.Save_Student(Student student)
        {
            if(!_DbContext.Students.Any(a => a.Id == student.Id)) // If student dont exists in DB Add it
            {
                _DbContext.Students.Add(student);   // Add the student
                await _DbContext.SaveChangesAsync(); // Save it
            }
        }


        // Save Teacher
        async Task IRepository.Save_Teacher(Teacher teacher)
        {
            if(!_DbContext.Teachers.Any(a => a.Id == teacher.Id))
            {
                _DbContext.Teachers.Add(teacher); // Add
                await _DbContext.SaveChangesAsync();  // Save
            }
        }
    }
}
