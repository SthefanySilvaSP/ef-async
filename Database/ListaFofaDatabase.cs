using System.Collections;
using System.Linq;
using System.Data;
using System;
using System.Net;

using System.Threading.Tasks;
using System.Collections.Generic;
namespace ef_async.Database
{
    public class ListaFofaDatabase
    {
        Models.lfdbContext context=new Models.lfdbContext();
        
        public async Task<List<Models.TbListaFofa>> Listar()
        {
            return await Task.Run(()=>context.TbListaFofa.ToList());
        }
    }
}