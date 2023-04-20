using System.Data.Entity.ModelConfiguration;
using Instagames.Entities.Domain_Models;

namespace Instagames.Database.EntitiesConfiguration
{
    class DeveloperConfig : EntityTypeConfiguration<Developer>
    {
        internal DeveloperConfig()
        {
            
            Property(g => g.FirstName)
              .IsRequired()
              .HasMaxLength(50);

            Property(g => g.LastName)
              .IsRequired()
              .HasMaxLength(50);

        }
    }
}
