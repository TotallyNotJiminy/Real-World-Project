using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Core.Entities
{
    public class MealPlan
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public List<DayPlan> DayPlans { get; set; }
        public DateTime StartDate { get; set; }
        public List<Recipe> LunchAlters { get; set; }
        public List<Recipe> SupperAlters { get; set; }
    }
}
