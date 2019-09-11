using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CervenecJustin_CodeExercise02
{
    class ContactInfo
    {
        string firstName;
        string lastName;
        string phoneNumber;
        string email;
        string relation;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Relation { get => relation; set => relation = value; }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
