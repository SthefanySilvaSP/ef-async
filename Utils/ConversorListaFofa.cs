using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ef_async.Utils
{
    public class ConversorListaFofa
    {
        public List<Models.Response.ListaFofaResponse> ParaResponse(List<Models.TbListaFofa> tb)
        {
            List<Models.Response.ListaFofaResponse> response=tb.Select(x=>new Models.Response.ListaFofaResponse(){
                     IdListaFofa=x.IdListaFofa,
                     Fofura=x.NmFofura,
                     Porque=x.DsPorque,
                     Potinho=x.BtColocariaPotinho,
                     Niver=x.DtNiver
            }).ToList();
       
            
            return response;
        }
    }
}