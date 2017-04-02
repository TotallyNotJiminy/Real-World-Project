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
    public class Ingredient: IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Key]
        public string id { get; set; }
        public string Name { get; set; }
        public float PricePerUnitOfMeasure { get; set; }
        public int CalPerUnitOfMeasure { get; set; }
    }
}
