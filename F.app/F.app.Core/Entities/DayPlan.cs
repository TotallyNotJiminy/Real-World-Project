using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Core.Entities
{
    public class DayPlan
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public Recipe Lunch { get; set; }
        public Recipe Supper { get; set; }
    }
}
