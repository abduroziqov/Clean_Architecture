using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Clean_Architecture.Domain.Models
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [NotNull]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }
        public string Description { get; set; }
        public int PhoneNumber { get; set; }
    }
}
