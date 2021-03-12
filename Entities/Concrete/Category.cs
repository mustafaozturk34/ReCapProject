using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int BlindId { get; set; }
        public string BlindName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
