using System;

namespace BaltaOOP.ContentContext{
    public abstract class Content{
        public Content(){
            //concentrando essa geracao de Guid na classe pai pra garantir 
            //o SPOF: Single Point of Failure
            Id = Guid.NewGuid();
        }
        public Guid Id{get; set;}
        public string Title{get; set;}
        public string Url{get; set;}
    }
}