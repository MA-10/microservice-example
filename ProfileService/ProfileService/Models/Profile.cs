using System;
using System.Collections.Generic;

#nullable disable

namespace ProfileService.Models
{
    public partial class Profile
    {
        public int Id { get; set; }
        public string FirstNmae { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
