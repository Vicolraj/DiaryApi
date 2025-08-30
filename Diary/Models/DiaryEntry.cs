using System.ComponentModel.DataAnnotations;

namespace Diary.Models
{
    public class DiaryEntry
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        [Key]
        public int Id { get; set; }
        [Required]
        public string Content { get; set; } = string.Empty;
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
    }
}
