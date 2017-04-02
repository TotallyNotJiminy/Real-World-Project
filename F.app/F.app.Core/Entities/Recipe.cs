using F.app.Core.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Core.Entities
{
    public class IngredientQuantity
    {
        public Ingredient ingredient { get; set; }
        int quantity { get; set; }
    }
    public class Recipe:IEntity
    {
        
        [BsonId]
        public ObjectId Id { get; set; }
        public string PrepInstruction { get; set; }
        public float ApproxDuration { get; set; }
        public List<IngredientQuantity> IngredientQ { get; set; }
        public int Rating { get; set; }
        public float Price { get; set; }
        public int TotCalories { get; set; }

    }
}
