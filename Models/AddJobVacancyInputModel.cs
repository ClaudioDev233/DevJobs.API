using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// O modelo, nada mais é que minha classe de criação de requisições para postar no meu "banco"
namespace DevJobs.API.Models
{
    //record simplifica a criação de objetos. Recebe um constructor de parametro
    public record AddJobVacancyInputModel(
    string Title,
    string Description,
    string Company,
    bool IsRemote,
    string SalaryRange)
    {
        
    }
}