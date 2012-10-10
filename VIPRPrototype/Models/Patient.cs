using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VIPRPrototype.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string SSNum { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public int AddressId { get; set; }

        public virtual ICollection<Chart> Charts { get; set; }

        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }

        public string FullName
        {
            get { return LastName + ", " + FirstName + " " + MiddleInitial; }
        }

    }
}
