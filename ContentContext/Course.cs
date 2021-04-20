using System.Collections.Generic;
using BaltaOOP.ContentContext.Enums;

namespace BaltaOOP.ContentContext{
    public class Course: Content{
        public Course(){
            Modules = new List<Module>();
        }
        public string Tag{get;set;}//Course code
        public IList<Module> Modules{get;set;}
        public int DurationInMinutes{get;set;}
        public EContentLevel Level{get;set;}
    }

}