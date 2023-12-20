using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionhand
{
    internal class excptionhand: Exception
    {
        public int DuplicateNumber { get; }
        //public exceptionhand(int duplicateNumber)
        //{
        //   

        //}
        public excptionhand(int duplicateNumber) : base($"Duplicate number found: {duplicateNumber}")
        {
            DuplicateNumber = duplicateNumber;
        }
    }
}
