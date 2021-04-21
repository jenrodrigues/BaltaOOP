using System.Collections.Generic;

namespace BaltaOOP.ContentContext{
    public class Career: Content{
        public Career(string title, string url): base(title, url){
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items{get;set;}
        public int TotalCount=>  Items.Count;
    }

    
}