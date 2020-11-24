﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace UdemyNLayerProject.Core.Models
{
    class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
