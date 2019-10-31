using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bakery.Data.Configurations
{
    //This tells the migration tool which DB table column names match which model class properties (in this case, for model Product)
    //only required when the name of the property isn't the same as the name of the DB table column
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.ImageName).HasColumnName("ImageFileName");
        }
    }
}
