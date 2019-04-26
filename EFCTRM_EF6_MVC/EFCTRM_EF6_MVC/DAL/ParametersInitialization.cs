using EFCTRM_EF6_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCTRM_EF6_MVC.DAL
{
    public class ParametersInitialization : System.Data.Entity.DropCreateDatabaseIfModelChanges<ParametersContext>
    {
        protected override void Seed(ParametersContext context)
        {
            // Create contacts
            var contact = new List<Contact>
            {
                new Contact{FirstName="Carson",     LastName="Alexander",   CreatedDateTime=DateTime.Parse("2005-09-01")},
                new Contact{FirstName="Meredith",   LastName="Alonso",      CreatedDateTime=DateTime.Parse("2002-09-01")},
                new Contact{FirstName="Arturo",     LastName="Anand",       CreatedDateTime=DateTime.Parse("2003-09-01")},
                new Contact{FirstName="Gytis",      LastName="Barzdukas",   CreatedDateTime=DateTime.Parse("2002-09-01")},
                new Contact{FirstName="Yan",        LastName="Li",          CreatedDateTime=DateTime.Parse("2002-09-01")},
                new Contact{FirstName="Peggy",      LastName="Justice",     CreatedDateTime=DateTime.Parse("2001-09-01")},
                new Contact{FirstName="Laura",      LastName="Norman",      CreatedDateTime=DateTime.Parse("2003-09-01")},
                new Contact{FirstName="Nino",       LastName="Olivetto",    CreatedDateTime=DateTime.Parse("2005-09-01")}
            };

            contact.ForEach(s => context.Contacts.Add(s));
            context.SaveChanges();

            var market = new List<Market>
            {
                new Market{ Name="LME",         Type = MarketType.Daily,    CreatedContactId=1,CreatedDateTime=DateTime.Parse("2005-09-01"), UpdateDateTime=DateTime.Parse("2005-09-01")},
                new Market{ Name="CME",         Type = MarketType.Daily,    CreatedContactId=2,CreatedDateTime=DateTime.Parse("2005-09-01"), UpdateDateTime=DateTime.Parse("2005-09-01")},
                new Market{ Name="COMEX",       Type = MarketType.Monthly,  CreatedContactId=3,CreatedDateTime=DateTime.Parse("2005-09-01"), UpdateDateTime=DateTime.Parse("2005-09-01")},
                new Market{ Name="NORDPOOL",    Type = MarketType.Daily,    CreatedContactId=4,CreatedDateTime=DateTime.Parse("2005-09-01"), UpdateDateTime=DateTime.Parse("2005-09-01")}
            };

            market.ForEach(s => context.Markets.Add(s));
            context.SaveChanges();
        }
    }
}