﻿using Agility.CoreData.Models;
using Agility.Data.SQLRepository.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agility.Data.SQLRepository
{
    public class DataContext : DbContext

    {

        public DataContext()

            : base("DefaultConnection")

        {



        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
            base.OnModelCreating(modelBuilder);
        }



        //for each model that needs persisting to the database we need a 

        //corresponding DbSet line like this
        public DbSet<Application> Applications { get; set; }
        public DbSet<DataModel> DataModels { get; set; }
        public DbSet<DataProperty> DataProperties { get; set; }
        public DbSet<Schema> Schemas { get; set; }
        public DbSet<SchemaProperty> SchemaProperties { get; set; }



    }
}
