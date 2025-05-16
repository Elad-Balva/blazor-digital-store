using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Clients.Model
{
    public class Client
    {
       public int Id { get; set; }

        //[Required(ErrorMessage = "First name is required")]
        //[MinLength(2, ErrorMessage = "First name must be at least 2 characters long")]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "First name must contain only")]
        public string? FirstName { get; set; }


        //[Required(ErrorMessage = "Last name is required")]
        //[MinLength(2, ErrorMessage = "Last name must be at least 2 characters long")]
        //[RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Last name must contain only English letters")]

        public string? LastName { get; set; }


        //[Required(ErrorMessage = "Email is required")]
        //[EmailAddress(ErrorMessage = "Invalid email format")]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email must contain a valid domain")]
        public string? Email { get; set; }


        //[Required(ErrorMessage = "Telephone is required")]
        //[Telephone(ErrorMessage = "Invalid telephone format")]
        //[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Telephone must contain a valid domain")]
        public string? Telephone { get; set; }


        //[Required(ErrorMessage = "Birth year is required")]
        //[Range(1000, 9999, ErrorMessage = "Birth Year must be a 4-digit number")]
        //[ValidBirthYear]
        public int BirthYear { get; set; }
        public City City { get; set; } = new City();
        public int Age => DateTime.Now.Year - BirthYear;
        public Client(int id, string firstname, string lastname, int birthyear,string telephone,string email, City city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            BirthYear = birthyear;
            Telephone = telephone;
            Email=email;
            City = city;
        }
        public Client() { }
    }
}
