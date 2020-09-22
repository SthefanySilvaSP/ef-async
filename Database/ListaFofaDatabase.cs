using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ef_async.Database
{
    public class ListaFofaDatabase
    {
        Models.lfdbContext context=new Models.lfdbContext();
        
        public async Task<List<Models.TbListaFofa>> Listar()
        {
            return await context.TbListaFofa.ToListAsync();
        }
    }
}