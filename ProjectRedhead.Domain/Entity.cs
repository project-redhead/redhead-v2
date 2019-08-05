using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectRedhead.Domain
{
    public class Entity
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }


        public Entity() : this(Guid.NewGuid().ToString())
        {
        }

        public Entity(string id)
        {
            Id = id;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            DeletedAt = null;
        }
    }
}
