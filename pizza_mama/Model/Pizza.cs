using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace pizza_mama.Model
{
    public class Pizza
    {
        [JsonIgnore]
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string nom { get; set; }

        [Display(Name = "Prix")]
        public float prix { get; set; }

        [Display(Name ="Végétarienne")]
        public bool vegetarienne { get; set; }

        
        [Display(Name = "Ingredients")]
        [JsonIgnore]
        public string ingredients { get; set; }

        //On ne veut pas le stocker dans la base de donnée : NotMapped
        [NotMapped]
        [JsonPropertyName("ingredients")]
        public string[] listeIngredients
        {
            get
            {
                if(ingredients == null || ingredients.Count() == 0)
                {
                    return null;
                }
                return ingredients.Split(", ");
            }
        }

    }
}
