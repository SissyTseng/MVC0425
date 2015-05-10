using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            return base.All().Where(p=>p.IsDelete==false).OrderBy(p=>p.ClientId);
        }

        internal IQueryable<Client> SelectGender(string gender)
        {
            return this.All().Where(p => p.Gender == gender).Take(10);
        }

        internal IQueryable<Client> SelectByCity(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return this.All();
            }
            else
            {
                return this.All().Where(p => p.City==city);
            }
        }

        public Client Find(int id)
        {
            return this.All().FirstOrDefault(p => p.ClientId == id);
        }
	}

	public  interface IClientRepository : IRepository<Client>
	{

	}
}