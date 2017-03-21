using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Core.Entities
{
    public class Ingredient
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public AllergicCategory AllergyCategory { get; set; }
        public float PricePerUnitOfMeasure { get; set; }
        public int CalPerUnitOfMeasure { get; set; }
    }
    public enum AllergicCategory
    {
        Seafood,
        Gluten,
        Lactose
    }
}
