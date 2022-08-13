using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Repositories.Contracts;
using Heroes.Models.Contracts;
using System.Linq;

namespace Heroes.Repositories
{
    public class HeroRepository : IRepository<IHero>
    {
        private readonly IList<IHero> models;
        public HeroRepository() : base()
        {
            models = new List<IHero>();
        }
        public IReadOnlyCollection<IHero> Models
        {
            get { return (IReadOnlyCollection<IHero>)models; } 
        }

        public void Add(IHero model)
        {
            if (models.All(x=>x.Name != model.Name))
            {
                models.Add(model);
            }
        }

        public IHero FindByName(string name)
        {
            var hero = models.FirstOrDefault(x => x.Name == name);
            if (hero == null)
            {
                return null;
            }
            return hero;
        }

        public bool Remove(IHero model)
        {
            var hero = models.FirstOrDefault(x => x.Name == model.Name);
            if (hero != null)
            {
                var indexOf = models.IndexOf(model);

                models.RemoveAt(indexOf);
                return true;
            }
            return false;
        }
    }
}
