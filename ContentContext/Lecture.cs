using System.Collections.Generic;
using BaltaOOP.ContentContext.Enums;

namespace BaltaOOP.ContentContext{
    public class Lecture{
        public int Order{get;set;}       
        public string Title{get;set;}       
        public int DurationInMinutes{get;set;}
        public EContentLevel Level{get;set;}
    }
}