using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceDivisorPrime.DTO
{
    public class ResultsDto
    {
        public long InputNumber { get; set; }
        public List<long> DivisorsList { get; set; }
        public List<long> PrimesList { get; set; }
    }
}
