using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceShop.Business.Definitions.Data.Config
{
    public class Actor_MovieConfiguration : IEntityTypeConfiguration<Actor_Movie>
    {
        public void Configure(EntityTypeBuilder<Actor_Movie> builder)
        {
            builder.HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });

            builder.HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            builder.HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);
        }
    }
}
