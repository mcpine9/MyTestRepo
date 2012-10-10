using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VIPRPrototype.Models
{
    public class Chart
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreateOnDate { get; set; }
        public int PatientId { get; set; }

        public virtual ICollection<Encounter> Encounters { get; set; }

        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
    }
}