using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMSim.Models
{
    /// <summary>
    /// Class that holds the PageNumber and Offset of a memory address.
    /// </summary>
    class MemoryAddress
    {
        /// <summary>
        /// Page number refers to the virtual/physical page number where the data is stored.
        /// </summary>
        public string PageNumber { get; set; }
        /// <summary>
        /// Offset is the place whithin the page where the data is stored.
        /// </summary>
        public string OffSet { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="VirtualAddress"></param>
        public MemoryAddress(string VirtualAddress)
        {
            PageNumber = VirtualAddress.Substring(0, 7);
            OffSet = "0x" + VirtualAddress.Substring(7);
        }

        /// <summary>
        /// Overloaded constructor.
        /// </summary>
        /// <param name="PageNumber"></param>
        /// <param name="OffSet"></param>
        public MemoryAddress(string PageNumber, string OffSet)
        {
            this.PageNumber = PageNumber;
            this.OffSet = OffSet;
        }

        /// <summary>
        /// Returns a string representation of the address.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return PageNumber + OffSet.Substring(2);
        }

    }
}
