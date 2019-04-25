using Business;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCTRMDataModel
{
    public class GeneralSetup : DbContext
    {
        public DbSet<Market> Markets { get; set; }
    }
}
