using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFGBackend.Models;

public class SesionDto
{

    public int IdSesion { get; set; }

    public string SesionTime { get; set; }

    public PistaDto Pista { get; set; }
}


