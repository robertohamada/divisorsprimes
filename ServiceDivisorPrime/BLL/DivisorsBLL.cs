using ServiceDivisorPrime.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceDivisorPrime.BLL
{
    public class DivisorsBLL
    {
        private bool VerifyPrime(long pNumber)
        {
            bool isPrime = true;
            for (Int64 j = 2; j < pNumber; j++)
            {
                if (pNumber % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }


        public ResultsDto Calc(long pNumber)
        {
            var dto = new ResultsDto();
            dto.InputNumber = pNumber;
            dto.DivisorsList = new List<long>();
            dto.PrimesList = new List<long>();
            //Int64.TryParse(pNumber, out Int64 numberConverted);
            if (pNumber > 1)
            {
                dto.DivisorsList.Add(1);
                dto.PrimesList.Add(1);
                //o 2 maiores divisores de um número é ele mesmo e a metade dele
                //então o loop não precisa ir além disso
                for (Int64 i = 2; i < (pNumber / 2) + 1; i++)
                {
                    if (pNumber % i == 0)
                    {
                        dto.DivisorsList.Add(i);
                        if (VerifyPrime(i))
                        {
                            dto.PrimesList.Add(i);
                        }
                    }
                }
                dto.DivisorsList.Add(pNumber);
                if (VerifyPrime(pNumber))
                {
                    dto.PrimesList.Add(pNumber);
                }
            }
            return dto;

        }

        public async Task<ResultsDto> GetDivisorsList(long pNumber)
        {
            return await Task.Run(() =>
            {
                try
                {
                    return Calc(pNumber);
                }
                catch (Exception)
                {
                    throw;
                }
            });
        }



    }
}
