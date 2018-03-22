// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KiwiTask.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the KiwiTask type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace KiwiTask.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class KiwiTask
    {
        public int Id { get; set; }

        public ApplicationUser Owner { get; set; }

        [Required]
        public string OwnerId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime AddDate { get; set; }
    }
}