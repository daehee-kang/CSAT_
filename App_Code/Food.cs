using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSAT.App_Code
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Food_Type Type { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Ingredient { get; set; }
        public string Description { get; set; }

        public Food(int id, string name, Food_Type type, double price, string image, string ingredient, string description)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
            Image = image;
            Ingredient = ingredient;
            Description = description;
        }

        public Food(string name, Food_Type type, double price, string image, string ingredient, string description)
        {
            Name = name;
            Type = type;
            Price = price;
            Image = image;
            Ingredient = ingredient;
            Description = description;
        }
    }

    public enum Food_Type
    {
        Appetizer,
        Lunch,
        Sushi,
        Sashimi,
        Udon,
        Teriyaki,
        Roll,
        Side,
        Add_on,
        Etc
    }
}