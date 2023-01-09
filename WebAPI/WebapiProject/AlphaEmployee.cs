using System.ComponentModel.DataAnnotations;


namespace WebapiProject
{
    public class AlphaEmployee
    {
        [Key] 
        public int id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
