using FikaCoffeeShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikaCoffeeShop.Core.DTOs
{
    public class OrderDto:BaseDto
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
