using Academia.Domain.Enums;
using System;

namespace Academia.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public int FullName { get; set; }

        public string CPF { get; set; }

        public DateTime Birthday { get; set; }

        public Address Address { get; set; }

        public EnumRole Role { get; set; }
    }
}