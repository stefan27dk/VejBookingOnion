using System.Collections;
using System.Threading.Tasks;

namespace Application.Services.StudentServices.Queries
{
    public interface IGetAllStudentsQuery
    {
        Task<IEnumerable> GetAll_Students();
    }
}