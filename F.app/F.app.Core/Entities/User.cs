using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F.app.Core.Entities
{
    public class Rating
    {
        Ingredient ingredient;
        int rating;
    }
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public bool Subscribed { get; set; }
        public List<Ingredient> Allergies { get; set; }
        public string AdressLine1 { get; set; }
        public string AdressLine2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public int MyProperty { get; set; }
        List<Rating> Ratings { get; set; }
        public float MaxBudget { get; set; }
        public int MaxCalories { get; set; }

        public virtual List<Ingredient> Ingredients { get; set; }

    }
}
