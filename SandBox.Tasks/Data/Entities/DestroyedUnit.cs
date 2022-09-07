using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandBox.Tasks.Data.Entities
{
    [Table("ddcs_units_dead")]
    public class DestroyedUnit
    {
        [Column("idDDCS_units_dead")]
        public int Id { get; set; }

        [Column("mission_id")]
        public string? MissionId { get; set; }

        [Column("sortie_id")]
        public string? SortieId { get; set; }

        [Column("target_unit_id")]
        public string? UnitId { get; set; }

    }
}
