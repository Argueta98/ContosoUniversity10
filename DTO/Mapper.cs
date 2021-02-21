using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity10.DTO;
using ContosoUniversity10.Models;


namespace ContosoUniversity10.DTO
{
    public class Mapper : Profile
    {
        public Mapper() 
        {
            CreateMap<StudentDTO, Student>();
            CreateMap<Student, StudentDTO>();
            
        }
    }
}
