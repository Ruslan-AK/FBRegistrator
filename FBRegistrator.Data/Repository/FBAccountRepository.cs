using System.Collections.Generic;
using System.Linq;
using FBRegistrator.Data.Context;

namespace FBRegistrator.Data.Repository
{
    public class FBAccountRepository : IRepository<FBAccount>
    {
        private readonly FBAccountContext context;
        public IEnumerable<FBAccount> All => context.FBAccounts.ToList();

        public FBAccountRepository(FBAccountContext context)
        {
            this.context = context;
        }

        public void Add(FBAccount entity)
        {
            context.FBAccounts.Add(entity);
            context.SaveChanges();
        }

        public void Delete(FBAccount entity)
        {
            context.FBAccounts.Remove(entity);
            context.SaveChanges(); 
        }

        public FBAccount FindById(long id)
        {
            return context.FBAccounts.FirstOrDefault(fba => fba.Id == id);
        }

        public FBAccount FindById(string id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(FBAccount entity)
        {
            context.FBAccounts.Update(entity);
            context.SaveChanges();
        }
    }
}