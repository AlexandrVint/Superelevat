using System;
using System.Data.Entity;
using System.Linq;
using Supelevator.Models;

namespace Supelevator.Base
{
    public class ModelFireLoad : DbContext
    {

        public ModelFireLoad()
            : base("name=ModelFireLoad")
        {
        }



        public virtual DbSet<FireLoadInfo> FireLoadInfos { get; set; }
    }


}