using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Description Is Requierd")]
        [MinLength(5,ErrorMessage ="Description Is Very Short")]
        public string Description { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime ?DueTime {  get; set; }



    }
}
