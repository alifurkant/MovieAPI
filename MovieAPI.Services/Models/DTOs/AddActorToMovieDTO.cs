﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.BLL.Models.DTOs
{
    public class AddActorToMovieDTO
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
    }
}
