using System.Data.Entity.ModelConfiguration;
using Instagames.Entities.Domain_Models;

namespace Instagames.Database.EntitiesConfiguration
{
    internal class MessageConfig :EntityTypeConfiguration<Message>
    {
        public MessageConfig()
        {
            Property(m => m.Text)
                .IsRequired()
                .HasMaxLength(80000);

            Property(m => m.SubmitDate)
                .IsRequired()
                .HasColumnType("date");

            //One to many 
            HasRequired(a => a.Creator)
                .WithMany(m => m.Messages)
                .Map(m=>m.MapKey("CreatorId"))
                .WillCascadeOnDelete();
        }
    }
}
