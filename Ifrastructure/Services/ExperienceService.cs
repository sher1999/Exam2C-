using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Ifrastructure.Services
{
    public class ExperienceService
    {
        private List<Experience> experiences;

        public ExperienceService()
        {
            experiences = new List<Experience>();
        }
        public List<Experience> GetExperiences()
        {
            return experiences;
        }
        public void Add(Experience experience)
        {
            experiences.Add(experience);
        }
        public void Update(Experience experience, int id)
        {
            var experienc = experiences.Find(t => t.Id == experience.Id);

            if (experiences == null) return;
        }
        public Experience GetExperienceById(int id)
        {
            Experience experience = experiences.Find(x => x.Id == id);
            return experience;
        }
        public List<Experience> GetExperiencesByUserId(int id)
        {
            Experience experience = experiences.Find(x => x.Id == id);
            return experiences;

        }
        public void Delete(int id)
        {
            var existing = experiences.Find(t => t.Id == id);
            if (existing == null) return;
            experiences.Remove(existing);
        }
        public int Count()
        {
            int count = experiences.Count();
            return count;
        }

    }
}
