﻿using MVC2.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC2.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory movieCategory { get; set; }

        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema 
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")] 
        public Cinema cinemas { get; set; }


        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer producers { get; set; }


    }
}
