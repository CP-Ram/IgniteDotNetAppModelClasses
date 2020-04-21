using Apache.Ignite.Core.Cache.Configuration;
using Models.Ignite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.People
{
    public class CompanyTypes:ICustomCacheStore
    {
        //primary key fields        
        [QuerySqlField]
        public string CompanyId { get; set; }       
        [QuerySqlField]
        public string CapabilityId { get; set; }
		
		 //other properties
        [QuerySqlField]
        public List<string> CompanyType { get; set; }
               
        [QuerySqlField]
        public string CapabilityName { get; set; }
       
        [QuerySqlField]
        private DateTime _CreatedDateTime;
        public DateTime CreatedDateTime
        {
            get { return _CreatedDateTime; }
            set
            {
                _CreatedDateTime = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }
        [QuerySqlField]
        private DateTime _ModifiedDateTime;
        public DateTime ModifiedDateTime
        {
            get { return _ModifiedDateTime; }
            set
            {
                _ModifiedDateTime = DateTime.SpecifyKind(value != null ? value : DateTime.UtcNow, DateTimeKind.Utc);
            }
        }

        [QuerySqlField]
        public bool IsDeleted { get; set; } = false;
        public CompanyTypes()
        {
            ModifiedDateTime = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);

            CreatedDateTime = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        }
    }
}
