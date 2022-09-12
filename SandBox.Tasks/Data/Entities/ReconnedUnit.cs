using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tasks.Data.Entities
{
    [Table("DDCS_units_recced")]
    public class ReconnedUnit
    {
        [Column("idDDCS_units_recced")]
        public int Id { get; set; }

        [Column("mission_id")]
        public string? MissionId { get; set; }

        [Column("unitName")]
        public string? UnitId { get; set; }

        [Column("type")]
        public string? Description { get; set; }

        [Column("clientName")]
        public string? DiscoveredBy { get; set; }

        [Column("lat")]
        public string? Latitude { get; set; }

        [Column("lon")]
        public string? Longitude { get; set; }

        [Column("alt")]
        public string? Altitude { get; set; }

    }
}
