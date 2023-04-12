using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
    
        {
            person_ person=new person_("Anabelle", "12345", "098765432");
            doctor_ doctor= new doctor_ ("Doctor","Especializacion");
            string appointmentResult = AppointmentService.CreateAppointment(person.Name, person.id, person.PhoneNumber, DateTime.Now, "Wall Street", doctor.DName);
            Console.WriteLine(appointmentResult);

           
        }
    }
}

