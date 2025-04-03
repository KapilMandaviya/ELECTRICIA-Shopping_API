
using DataAccessLayer.DTO;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public partial class ELECTRICIADBContext
    {
        public virtual DbSet<BlogDetailDTO> BlogDetailDTO { get; set; }
        public virtual DbSet<SPCategoryList> SPCategoryList { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogDetailDTO>().HasNoKey().ToView(null); // No table mapping, just for queries
            modelBuilder.Entity<SPCategoryList>().HasNoKey().ToView(null); // No table mapping, just for queries
        }
    }
}
