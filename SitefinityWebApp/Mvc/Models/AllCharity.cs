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

        public AllCharity(string title, string reporturl, bool accredited)
        {
            this._name = title;
            this._url = reporturl;
            this._accreditied = accredited;

        }

        public string Name { get { return this._name; } }
        public string Url { get { return this._url; } }

        public bool Accredited
        {
            get { return this._accreditied; }
        }


        private readonly string _name;
        private readonly string _url;
        private readonly bool _accreditied;

        public int CompareTo(AllCharity other)
        {
            return this.Name.CompareTo(other.Name);

        }
    }
}