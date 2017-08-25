using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace emotionFranco.Web.Models
{
    public class emotionFrancoWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public emotionFrancoWebContext() : base("name=emotionFrancoWebContext")
        {
            Database.SetInitializer<emotionFrancoWebContext>(
                new DropCreateDatabaseIfModelChanges<emotionFrancoWebContext>());
        }

        public DbSet<EmoPicture> EmoPictures { get; set; }

        public DbSet<EmoFace> EmoFaces { get; set; }

        public DbSet<EmoEmotion> EmoEmotions { get; set; }

        public System.Data.Entity.DbSet<emotionFranco.Web.Models.Home> Homes { get; set; }
    }
}
