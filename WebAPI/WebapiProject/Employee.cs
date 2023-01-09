using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebapiProject
{
    public class Employee
    {
        /*[Key]*/
        public int? Id { get; set; }


        /*[Required(ErrorMessage ="Enter the employee name")]
        [Display(Name ="Employee name")]
        [StringLength(10)]*/
        public string Name { get; set; }

        /*[Required (ErrorMessage ="Enter the contact number")]
        [Display (Name ="Employee contact number")]
        [MaxLength(10)]*/
        public long EmpContactNumber { get; set; }
    }
}
