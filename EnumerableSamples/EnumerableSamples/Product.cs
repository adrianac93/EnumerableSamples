﻿namespace EnumerableSamples
{
    public class Product
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Id}\t{Name}\t{Price:C2}";
        }
    }
}
