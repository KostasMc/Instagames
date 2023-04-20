using System.Data.Entity.ModelConfiguration;
using Instagames.Entities.Domain_Models;

namespace Instagames.Database.EntitiesConfiguration
{
    internal class PegiConfig :EntityTypeConfiguration<Pegi>
    {
        internal PegiConfig()
        {
            ToTable("Pegi");

            Property(p => p.PegiAge)
                .IsRequired()
                .HasColumnType("tinyint");

            Property(p => p.PegiPhoto)
                .IsRequired();
        }
    }
}
