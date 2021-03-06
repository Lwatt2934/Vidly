﻿using System;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        public GenreDto Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public DateTime? DateAdded { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20)]
        [Required]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}