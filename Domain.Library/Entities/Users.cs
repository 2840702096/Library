using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Domain.Entities
{
    public class Users
    {
        public Users()
        {

        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        #region Relations

        public ICollection<Users_Books> Users_Books { get; set; }

        #endregion
    }
}
