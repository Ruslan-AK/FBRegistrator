using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using FBRegistrator.Data.Context;
using System;
using FBRegistrator.Data.Repository;

namespace fbregistrator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FBAccountController : ControllerBase {
        private IRepository<FBAccount> contextFBAccount;

        public FBAccountController(IRepository<FBAccount> context)
        {
            this.contextFBAccount = context;
        }

        [HttpGet("getall")]
        public IEnumerable<FBAccount> GetAll()
        {
            return contextFBAccount.All;
        }

        [HttpGet("getbyid/{id}")]
        public FBAccount GetById(long? id)
        {
            return id.HasValue ? contextFBAccount.FindById(id.Value) : null;
        }

        [HttpPost("createaccount")]
        public FBAccount Create(FBAccount account)
        {
            if (account.Id == 0) {
                throw new Exception("id can't be 0 or null");
            }
            contextFBAccount.Add(account);
            return account;
        }
    }
}