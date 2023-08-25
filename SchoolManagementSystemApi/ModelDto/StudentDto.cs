﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystemApi.ModelDto
{
    public class StudentDto
    {
       
        public int Id { get; set; }

       
        public string Name { get; set; }
      
        public string PresentAddress { get; set; }
        
        public string RollNumber { get; set; }
      
        public string ContactNo { get; set; }
    }
}
