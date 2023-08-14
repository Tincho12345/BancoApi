using System.Collections.Generic;

namespace Application.Wrappers
{
    // Clase genérica para responder a los errores
    // es una Clase que recibe un Tipo, Clase Genérica para 
    // Darle formato a mis mensajes
    public class Response<T>
    {
        public Response()
        {

        }

        public Response(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }

        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
    }
}
