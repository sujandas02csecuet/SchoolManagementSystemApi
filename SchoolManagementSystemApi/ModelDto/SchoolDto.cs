using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystemApi.ModelDto
{
    public class SchoolDto
    {
       
        public int Id { get; set; }

        
        public string Name { get; set; }
       
        public string SchoolAddress { get; set; }
      
        public string Code { get; set; }
       
        public string MediumOfTeaching { get; set; }

        public string Flag { get; set; }
    }
}
