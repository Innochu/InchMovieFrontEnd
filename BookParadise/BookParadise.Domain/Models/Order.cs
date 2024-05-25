﻿using BookParadise.Domain.Enums;
using BookParadise.Domain.SharedEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookParadise.Domain.Models
{
    public class Order : BaseEntity
    {
        public int Quantity { get; set; }
        [ForeignKey("BookId")]
        public string BookId { get; set; }

        [ForeignKey("UserId")]
        public string UserId { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }
}
