// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KiwiTaskViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   View Model for KiwiTask
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace KiwiTask.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class KiwiTaskViewModel
    {
        [Display(Name = "Name")]
        public string TaskName { get; set; }

        [Display(Name = "Description")]
        public string TaskDescription { get; set; }

        [Display(Name = "Due Date")]
        public string DueDate { get; set; }
    }
}