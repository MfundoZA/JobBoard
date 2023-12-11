namespace JobBoard.API.Models
{
    public class Skill
    {
        public int Id { get; private set; }
        public string SkillTitle { get; set; } = null!;
        public string SkillCatergory { get; set; } = null!;
        public List<Profile>? Profiles { get; set; } 

        public Skill()
        {
                    
        }

        public Skill(int id, string skillTitle, string skillCatergory)
        {
            Id = id;
            SkillTitle = skillTitle;
            SkillCatergory = skillCatergory;
        }
    }
}