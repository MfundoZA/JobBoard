using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Data.Models
{
    public class ProfileCertification
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; } = null!;

        public int CertificationId { get; set; }
        public Certification Certification { get; set; } = null!;

        public ProfileCertification() { }

        public ProfileCertification(int profileId, int certificationId)
        {
            ProfileId = profileId;
            CertificationId = certificationId;
        }

        public ProfileCertification(Profile profile, Certification certification)
        {
            Profile = profile;
            Certification = certification;
        }
    }
}
