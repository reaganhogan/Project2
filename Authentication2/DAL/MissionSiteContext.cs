using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Authentication2.Models;

namespace Authentication2.DAL
{
    public class MissionSiteContext : DbContext
    {
        public MissionSiteContext() : base("MissionSiteContext")
        { }
        public DbSet<Missions> Missions { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<MissionQuestions> MissionQuestions { get; set; }
    }
}
