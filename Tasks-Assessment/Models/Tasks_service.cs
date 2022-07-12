using Microsoft.AspNetCore;

namespace Tasks_Assessment.Models
{
    public class Tasks_service
    {
        public int Id { get; set; }
        public string? Description { get; set; }

        public int Priority { get; set; }

        public string? Status { get; set; }

        public int CustomerId { get; set; }

            
    }

}
