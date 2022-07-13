using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionExercises
{
    public class Robot : IIdentifiable
    {
        private string id;
        public string Model { get; set; }
        public string Id { get => this.id; set => this.id = value; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
