using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace VIPRPrototype.Models
{
    public class Encounter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime VisitTime { get; set; }
        public int ProviderId { get; set; }
        public int ChartId { get; set; }

        [ForeignKey("ProviderId")]
        public virtual Provider AttendingPhysician { get; set; }

        [ForeignKey("ChartId")]
        public virtual Chart Chart { get; set; }
    }
}