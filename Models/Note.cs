using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kdhhome.Models
{
    public class Note
    {
        [Key]
        public int NoteNO { get; set; }
        [Required(ErrorMessage = "제목을 입력하세요.")]
       
        public string NoteTitle { get; set; }
        [Required(ErrorMessage = "내용을 입력하세요")]
       
        public  string NoteContents { get; set; }
        [Required]

        public int UserNo{ get; set; }
        
        [ForeignKey("UserNo")]
        public virtual User User { get; set; }
    
    }
}
