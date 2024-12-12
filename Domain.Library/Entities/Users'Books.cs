using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Entities
{
    public class Users_Books
    {
        public Users_Books()
        {

        }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public bool IsReturned { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsPaid { get; set; }

        #region Relations

        [ForeignKey("UserId")]
        public virtual Users User { get; set; }

        [ForeignKey("BookId")]
        public virtual Books Book { get; set; }

        #endregion
    }
}
