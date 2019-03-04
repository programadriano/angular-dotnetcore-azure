using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain
{
    public interface IDestaqueService
    {
        Destaques GetAll();
    }
}
