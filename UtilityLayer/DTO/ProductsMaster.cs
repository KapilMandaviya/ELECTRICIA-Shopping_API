using System;
using System.Collections.Generic;

namespace UtilityLayer.DTO
{

    public partial class ProductsMaster_DTO
    {
        public int ProductId { get; set; }

        public string? PName { get; set; }

        public string? PSku { get; set; }

        public string? CategoryId { get; set; }

        public double? PBasePrice { get; set; }

        public int? PStock { get; set; }

        public string? PDescription { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedByUserId { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool? IsDelete { get; set; }

        public string? ModifyAction { get; set; }
    }
}