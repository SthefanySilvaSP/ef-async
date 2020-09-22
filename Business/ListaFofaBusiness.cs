using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ef_async.Business
{
    public class ListaFofaBusiness
    {
        Database.ListaFofaDatabase database = new Database.ListaFofaDatabase();


        public async Task<List<Models.TbListaFofa>> ValidarListaFofa()
        {
            List<Models.TbListaFofa> listaFofa = await database.Listar();

            if(listaFofa.Count==0)
                throw new ArgumentException("nenhum registro encontrado");

            return listaFofa;
        }
    }
}