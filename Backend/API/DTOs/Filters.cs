using System;
using System.Collections.Generic;
using System.Text;
using static DTOs.Filters;

namespace DTOs
{

    public class SearchBy
    {
        public string Sreach { get; set; }
        public Categories Categories { get; set; }
        public Genders Gender { get; set; }
        public Conditions Condition { get; set; }
        public PriceRange PriceRange { get; set; }
        public bool FreeShippig { get; set; }
    }


    public class Filters
    {
        public enum Categories
        {
            All = 0,
            Toys = 1,
            Clothes = 2
        }
        public enum Genders
        {
            Male = 0,
            Female = 1
        }
        public enum Conditions
        {
            New = 0,
            Used = 1
        }

        public class PriceRange
        {
            public double From { get; set; }
            public double To { get; set; }
        }


    }
}
