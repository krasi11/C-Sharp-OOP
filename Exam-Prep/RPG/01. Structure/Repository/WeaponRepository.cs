using System;
using System.Collections.Generic;
using System.Text;
using Heroes.Repositories.Contracts;
using Heroes.Models.Contracts;
using System.Linq;


namespace Heroes.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private readonly IList<IWeapon> models;
        public WeaponRepository() : base()
        {
            models = new List<IWeapon>();
        }
        public IReadOnlyCollection<IWeapon> Models
        {
            get { return (IReadOnlyCollection<IWeapon>)models; }
        }

        public void Add(IWeapon model)
        {
            if (models.All(x=>x.Name != model.Name))
            {
                models.Add(model);
            }
        }

        public IWeapon FindByName(string name)
        {
            var weapon = models.FirstOrDefault(x => x.Name == name);
            if (weapon == null)
            {
                return null;
            }
            return weapon;
        }

        public bool Remove(IWeapon model)
        {
            var WeapongToRemove = models.FirstOrDefault(x => x.Name == model.Name);
            if (WeapongToRemove != null)
            {
                var indexOfWeapon = models.IndexOf(model);
                models.RemoveAt(indexOfWeapon);
                return true;
            }
            return false;
        }
    }
}
