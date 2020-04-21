using Apache.Ignite.Core.Cache.Configuration;
using Models.Ignite;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.People
{
    public class Company:ICustomCacheStore
    {
        [QuerySqlField]
        public string EntityId { get; set; }

        [QuerySqlField]
        public string EntityType { get; set; }


        [QuerySqlField]
        public string EntityName { get; set; }


        [QuerySqlField]
        public int NoOfEmployees { get; set; }


        [QuerySqlField]
        public bool IsDeleted { get; set; } = false;

        [QuerySqlField]
        public string CompanyType { get; set; }       

        [QuerySqlField]
        public string CreatedBy { get; set; }

        [QuerySqlField]
        private DateTime _Created;
       
        public DateTime Created
        {
            get { return _Created; }
            set
            {
                _Created = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        public string CountryCode { get; set; }

        [QuerySqlField]
        public string ModifiedBy { get; set; }

        [QuerySqlField]
        private DateTime _Modified;

        public DateTime Modified
        {
            get { return _Modified; }
            set
            {
                _Modified = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }            
        

        public Company()
        {
            Modified = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            Created = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
           
        }   


    }
}
