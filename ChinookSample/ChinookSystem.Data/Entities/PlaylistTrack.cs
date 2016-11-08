using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace ChinookSystem.Data.Entities
{
    [Table("PlaylistTracks")]
    public class PlaylistTrack
    {
        [Key, Column(Order = 1)]
        public int PlaylistId { get; set; }
        public int TrackId { get; set; }
        public int TrackNumber { get; set; }
        public virtual Track Track { get; set; }
        public virtual PlayList PlayList { get; set; }
    }
}
