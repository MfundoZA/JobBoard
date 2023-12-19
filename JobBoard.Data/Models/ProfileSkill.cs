using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Data.Models
{
    public class ProfileSkill
    {
        public int Id { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; } = null!;

        public int SkillId { get; set; }
        public Skill Skill { get; set; } = null!;

        public ProfileSkill() { }

        public ProfileSkill(int profileId, int skillId)
        {
            ProfileId = profileId;
            SkillId = skillId;
        }

        public ProfileSkill(Profile profile, Skill skill)
        {
            Profile = profile;
            Skill = skill;
        }
    }
}
