using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMSim.Models
{
    /// <summary>
    /// This class is the translation lookaside buffer.
    /// </summary>
    public class TLB
    {

        /// <summary>
        /// The maximum number of rows in the table.
        /// </summary>
        public int TLBMaxSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TLBRow> table = new List<TLBRow>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public string GetPPN(string tag)
        {
            for (int i = 0; i < table.Count; i++)
            {
                if (table[i].tag == tag)
                    return table[i].ppn;
            }
            return null;
        }

        /// <summary>
        /// Add a new record in the TLB while removing the earliest used record.
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="ppn"></param>
        public void AddAddress(string tag, string ppn)
        {
            if(table.Count  == TLBMaxSize)
                table.RemoveAt(0);

            table.Add(new TLBRow(tag, ppn));
        }

        /// <summary>
        /// Load a buch of stuffs into the TLB.
        /// </summary>
        /// <param name="rows"></param>
        public void LoadPageTableData(string[,] rows)
        {
            for (int i = 0; i < rows.GetLength(0); i++)
                table.Add(new TLBRow(rows[i, 0], rows[i, 1]));
        }

    }

    /// <summary>
    /// Each entry in the TLB is a TLB Row.
    /// </summary>
    public class TLBRow
    {
        /// <summary>
        /// tag references the place in the page table where the address is.
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// ppn is the physical page number where the data is stored.
        /// </summary>
        public string ppn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="ppn"></param>
        public TLBRow(string tag, string ppn)
        {
            this.tag = tag;
            this.ppn = ppn;
        }

    }

}
