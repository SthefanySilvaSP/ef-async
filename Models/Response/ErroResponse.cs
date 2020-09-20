namespace ef_async.Models.Response
{
    public class ErroResponse
    {
          public class Erro
          {
              public int Codigo { get; set; }
              public string Mensagem { get; set; }
              public Erro(int cod,string mensagem)
              {
                  this.Codigo=cod;

                  this.Mensagem=mensagem;
              }
          }
    }
}