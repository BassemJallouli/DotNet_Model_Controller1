using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationDotNet.Models
{
    public class CarDetails
    {
        public Guid Id { get; set; }

        public bool Title { get; set; }

        public string Year { get; set; }

        public string Description { get; set; }
    }
}
