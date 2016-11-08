using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additonal Namespaces
using System.ComponentModel; //ODS
using ChinookSystem.Data.Entities;
using ChinookSystem.Data.POCOs;
using ChinookSystem.DAL;
#endregion

namespace ChinookSystem.BLL
{
    [DataObject]
    public class PlaylistController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<TracksForPlaylist> Get_PlaylistTracks(string playlistname, string customerid)
        {
            using (var context = new ChinookContext())
            {
                var results = from x in context.PlaylistTracks
                              where x.PlayList.Name.Equals(playlistname)
                              //&& x.PlayList.CustomerID.Equals(customerid)
                              select new TracksForPlaylist
                              {
                                  TrackId = x.TrackId,
                                  TrackNumber = 1,
                                  Name = x.Track.Name,
                                  Title = x.Track.Album.Title,
                                  Milliseconds = x.Track.Milliseconds,
                                  UnitPrice = x.Track.UnitPrice,
                                  Purchased = true
                              };
                return results.ToList();

            }
        }
    }
}
