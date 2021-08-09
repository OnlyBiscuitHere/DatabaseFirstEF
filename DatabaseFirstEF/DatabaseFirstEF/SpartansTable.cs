using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstEF
{
    public partial class SpartansTable
    {
        public int SpartanId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
        public string Course { get; set; }
        public string Grade { get; set; }
        public int? Mark { get; set; }
    }
}
