using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Appointments
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public String PatientLastname { get; set; }
        public String Hospital { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public Appointments()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {

        }
    }
}
