﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AccProductsEnt.Kuriev.Entities.DTO
{
    public class InputOrder
    {
        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Название заказа")]
        public string Name { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Количество")]
        public string Quantity { get; set; }

        [Required]
        [Display(Name = "Дата заказа")]
        [DataType(DataType.Date)]
        public DateTime OrdersDate { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Лимит превышен {1}")]
        [Display(Name = "Стоимость")]
        public string Cost { get; set; }
    }
}
