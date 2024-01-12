using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace QLKS.Models
{
    public class User : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string HashedPassword { get; set; }
        [JsonIgnore]
        public byte[] Salt { get; set; }
        public Role Role { get; set; }
        [JsonIgnore]
        public virtual List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
