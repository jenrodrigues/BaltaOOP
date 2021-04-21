using System.Collections.Generic;
using System.Linq;
using BaltaOOP.NotificationContext;
using BaltaOOP.SharedContext;

namespace BaltaOOP.SubscriptionContext{
    public class Student:Base{
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x=> !x.IsInactive);
        
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }

        public void CreateSubscription(Subscription subscription){
            if (IsPremium){
                AddNotification(new Notification("Premium", "O aluno ja tem assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}