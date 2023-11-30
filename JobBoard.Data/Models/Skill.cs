namespace JobBoard.API.Models
{
    public class Skill
    {
        public int Id { get; private set; }
        public string SkillName { get; set; }
        public string SkillCatergory { get; set; }

        public Skill()
        {
                    
        }

        public Skill(int id, string skillName, string skillCatergory)
        {
            Id = id;
            SkillName = skillName;
            SkillCatergory = skillCatergory;
        }
    }
}