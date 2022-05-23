using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pastelaria.Domain;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Pastelaria.ORM.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        private Bitmap bmp;

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("DOMAIN.PRODUCT");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).HasColumnType("VARCHAR(75)").IsRequired();
            builder.Property(p => p.Value).HasColumnType("DECIMAL").IsRequired();
            builder.Property(p => p.Description).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.Image).HasConversion(v => ConvertToArray(v), v => ConvertToBitmap(v));
        }

        #region Privates

        protected byte[] ConvertToArray(Bitmap entidade)
        {
            bmp = entidade;
            MemoryStream memoria = new();
            bmp.Save(memoria, ImageFormat.Bmp);
            byte[] imagemByte = memoria.ToArray();

            return imagemByte;
        }
        protected Bitmap ConvertToBitmap(byte[] byteArray)
        {

            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            bmp = (Bitmap)tc.ConvertFrom(byteArray);
            Bitmap imagem = new(bmp);

            return imagem;
        }

        #endregion
    }
}
