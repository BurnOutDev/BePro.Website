using BePro.Website.Public.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BePro.Website.Public.DAL
{
    public class CommonContext : DbContext
    {
        public CommonContext() : base("CommonDatabase")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CommonContext>());
        }

        public DbSet<RegistrationEntity> RegistrationEntities { get; set; }
    }
}