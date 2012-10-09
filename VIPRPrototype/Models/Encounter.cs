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
        public int ChartId { get; set; }

        [ForeignKey("ProviderId")]
        [DisplayName("Physician")]
        public virtual Provider AttendingPhysician { get; set; }

        [ForeignKey("ChartId")]
        public virtual Chart Chart { get; set; }
    }
}