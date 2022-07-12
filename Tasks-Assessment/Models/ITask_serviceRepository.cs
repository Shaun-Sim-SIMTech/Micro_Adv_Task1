
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tasks_Assessment.Models
{
    public interface Itask_serviceRepository
    {
        Task<IEnumerable<Tasks_service>> Gettask_servicesAsync();

        Task<Tasks_service> Gettask_serviceByIdAsync(int id);

        Task<Tasks_service> Addtask_serviceAsync(Tasks_service task_service);

        Task<Tasks_service> Deletetask_serviceAsync(int id);

        Task<Tasks_service> Updatetask_serviceAsync(int id, Tasks_service task_service);

    }
}
