using System;
using BaltaOOP.NotificationContext;

namespace BaltaOOP.SharedContext{
    public abstract class Base: Notifiable{
        public Guid Id{get; set;}

        public Base(){
            //concentrando essa geracao de Guid na classe pai pra garantir 
            //o SPOF: Single Point of Failure
            Id = Guid.NewGuid();
        }
        
    }
}