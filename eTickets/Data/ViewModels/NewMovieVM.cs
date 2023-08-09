using eTickets.Data.Base;
using eTickets.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie Name")]
        [Required(ErrorMessage = "Name is requered")]
        public string Name { get; set; }
        [Display(Name = "Movie Description")]
        [Required(ErrorMessage = "Description is requered")]
        public string Description { get; set; }
        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is requered")]
        public double Price { get; set; }
        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is requered")]
        public string ImageURL { get; set; }
        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is requered")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is requered")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Selecet a category")]
        [Required(ErrorMessage = "Movie category is requered")]
        public MovieCategoryEnum MovieCategory { get; set; }
        [Display(Name = "Selecet actor(s)")]
        [Required(ErrorMessage = "Movie actor(s) is requered")]
        public List<int> ActorsIds { get; set; }
        [Display(Name = "Selecet a cinema")]
        [Required(ErrorMessage = "Movie cinema is requered")]
        public int CinemaId { get; set; }
        [Display(Name = "Selecet a producer")]
        [Required(ErrorMessage = "Movie producer is requered")]
        public int ProducerId { get; set; }
    }
}
