using System;
using System.Collections.Generic;

namespace UtilityLayer.DTO
{


    public partial class CartItem_DTO
    {
        public int CartItemId { get; set; }

        public int? CartId { get; set; }

        public int? ProductId { get; set; }

        public int? Quantity { get; set; }

        public double? Price { get; set; }

        public double? Subtotal { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedByUserId { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool? IsDelete { get; set; }

        public string? ModifyAction { get; set; }
    }
}