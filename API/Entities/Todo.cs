using System;
using API.Data;

namespace API.Entities
{
    public class Todo : BaseEntity
    {
        public string Description { get; set; }

        public DateTime Created { get; set; }

        public bool IsDone { get; set; }
    }
}