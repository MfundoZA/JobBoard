using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Data.Models
{
    public class ProfileOpening
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; } = null!;

        public int OpeningId { get; set; }
        public Opening Opening { get; set; } = null!;

        public ProfileOpening() { }

        public ProfileOpening(int profileId, int openingId)
        {
            ProfileId = profileId;
            OpeningId = openingId;
        }

        public ProfileOpening(Profile profile, Opening opening)
        {
            Profile = profile;
            Opening = opening;
        }
    }
}
