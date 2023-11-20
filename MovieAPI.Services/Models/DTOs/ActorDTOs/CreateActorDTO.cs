using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Models.DTOs.ActorDTOs
{
    public class CreateActorDTO
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
