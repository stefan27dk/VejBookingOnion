using Application.Interfaces.InfratructureInterfaces;
using Persistence.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.StudentServices.Queries
{
    public class GetAllStudentsQuery : IGetAllStudentsQuery
    {

        private readonly IRepository _IRepository;

        // Constructor
        public GetAllStudentsQuery(IRepository iRepository)
        {
            _IRepository = iRepository;
        }



        // Get All Students
        public async Task<IEnumerable> GetAll_Students()
        {
            return await _IRepository.GetAll_Students();
        }




    }
}
