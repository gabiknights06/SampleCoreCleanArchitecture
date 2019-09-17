using Sample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core.Models
{
    public class Person : IPerson
    {
        public Person()
        {
            CompanyRefence = new Company();
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
            Company = 0;
            Id = 0;
            RecordState = 0;
            Timestamp = DateTime.Now;
            ModifiedTimestamp = DateTime.Now;
        }
        public Company CompanyRefence { get; set; }
        public string FullName
        {
            get
            {
                if (MiddleName == string.Empty)
                {
                    return $"{ FirstName } {LastName}";
                }
                else
                {
                    return $"{ FirstName } { MiddleName } { LastName }";
                }
            }
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Company { get; set; }
        public int Id { get; set; }
        public int RecordState { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime ModifiedTimestamp { get; set; }
    }
}
