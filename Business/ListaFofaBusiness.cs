using System.Collections;
using System.Linq;
using System.Data;
using System;
using System.Net;

using System.Threading.Tasks;
using System.Collections.Generic;

namespace ef_async.Business
{
    public class ListaFofaBusiness
    {
        Database.ListaFofaDatabase database=new Database.ListaFofaDatabase();
        public async Task<List<Models.TbListaFofa>> ValidarListaFofa()
        {
            List<Models.TbListaFofa> listaFofa=await database.Listar();
            return listaFofa;
             
        }
    }
}