using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMSim.Models
{
    class MemoryManager
    {

        public TLB tlb = new TLB()
        {
            TLBMaxSize = 2
        };

        public PT pt = new PT();

        public MemoryAddress GetPhysicalAddress(string virtualAddress)
        {

            MemoryAddress address = new MemoryAddress(virtualAddress);

            LoadFromTLB:

            var ppn = tlb.GetPPN(address.PageNumber);

            if (ppn == null)
            {
                LoadFromPT(address);
                goto LoadFromTLB;
            }
            else
            {
                address.PageNumber = ppn;
            }

            return address;
        }

        private void LoadFromPT(MemoryAddress virtualAddress)
        {
            string ppn = pt.GetPPN(virtualAddress.PageNumber);

            tlb.AddAddress(virtualAddress.PageNumber, ppn);

        }

        public string[] GetTLBArray()
        {
            string[] returnList = new string[tlb.table.Count];
            for (int i = 0; i < tlb.table.Count; i++)
                returnList[i] = tlb.table[i].tag + " - " + tlb.table[i].ppn;
            return returnList;
        }

        public string[] GetPTArray()
        {
            string[] returnList = new string[pt.table.Count];
            for (int i = 0; i < pt.table.Count; i++)
                returnList[i] = pt.table[i].ppn;
            return returnList;
        }

    }

}
