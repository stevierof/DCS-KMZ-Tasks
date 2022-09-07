using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tasks.Data.Entities
{
    [Table("ddcs_units_recced")]
    public class ReconnedUnit
    {
        [Column("idDDCS_units_recced")]
        public int Id { get; set; }

        [Column("mission_id")]
        public int MissionId { get; set; }

        [Column("unitName")]
        public int UnitId { get; set; }

        [Column("type")]
        public int Description { get; set; }

        [Column("clientName")]
        public int DiscoveredBy { get; set; }

        [Column("lat")]
        public long Latitude { get; set; }

        [Column("lon")]
        public long Longitude { get; set; }

        [Column("alt")]
        public long Altitude { get; set; }

    }
}
