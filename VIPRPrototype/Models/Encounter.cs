using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VIPRPrototype.Models
{
    public class Encounter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DisplayName("Visit Time")]
        [DisplayFormat(DataFormatString = "{0:G}")]
        public DateTime VisitTime { get; set; }
        public int ProviderId { get; set; }

        [DisplayName("Physician")]
        public virtual Provider Provider { get; set; }
    }
}