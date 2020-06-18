using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SitefinityWebApp.Mvc.Models
{
    public class AllCharity : IComparable<AllCharity>
    {

        public AllCharity(string title, string reporturl, bool accredited, string[] alternativenames)
        {
            this._name = title;
            this._url = reporturl;
            this._accredited = accredited;

            List<string> parsedAlternativeNames = new List<string>();
            foreach (string akastring in alternativenames)
            {
                if (akastring.Length > 0)
                {
                    string trimmedAka = akastring.Remove(akastring.Length - 1, 1);
                    parsedAlternativeNames.AddRange(trimmedAka.Split('|'));
                   // var itemToRemove = parsedAlternativeNames.FirstOrDefault(e => e == title);
                    parsedAlternativeNames.RemoveAll(e => e == title);
                }
                
            }
            this._alternativeNames = parsedAlternativeNames;

        }
        public IList<string> AlternativeNames { get { return this._alternativeNames; } }
        public string Name { get { return this._name; } }
        
    public string Url { get { return this._url; } }

        public bool Accredited
        {
            get { return this._accredited; }
        }

        



private readonly string _name;
        private readonly string _url;
        private readonly bool _accredited;
        private readonly IList<string> _alternativeNames;
        public int CompareTo(AllCharity other)
        {
            return this.Name.CompareTo(other.Name);

        }
    }
}