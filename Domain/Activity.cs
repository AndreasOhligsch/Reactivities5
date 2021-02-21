using System;

namespace Domain
{
    public class Activity
    {
        // These properties represent columns in our Database Table
        // Because we have named our Identity Field 'Id', then by convention of EntityFramework, this is going to be used as our Primary Key in Our Table
        // When we create a migration, it's going to create a script form which we can create a Database from.
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date {get; set;}
        public string Description { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}