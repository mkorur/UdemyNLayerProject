﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyNLayerProject.Core.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Stock { get; set; }

        public decimal Proce { get; set; }

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public string InnerBarcode { get; set; }

        public virtual Category Category { get; set; }
		
		public string AuthorName { get; set; }
    }
}
