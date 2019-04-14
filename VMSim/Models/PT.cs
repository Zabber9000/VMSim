using System;
using System.Collections.Generic;

namespace VMSim.Models
{

    /// <summary>
    /// PT is the page table that holds all physical page tocations of the data.
    /// </summary>
    public class PT
    {

        /// <summary>
        /// The maximum number of rows in the table.
        /// </summary>
        public int PTMaxSize = 20;

        /// <summary>
        /// 
        /// </summary>
        public List<PTRow> table = new List<PTRow>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppn"></param>
        public void AddAddress(string ppn)
        {
            if (table.Count == PTMaxSize)
                table.RemoveAt(1);

            table.Add(new PTRow(ppn));
        }

        /// <summary>
        /// Gets PPN at index dirived from TAG.
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public string GetPPN(string pageNumber)
        {
            int index = Convert.ToInt32(pageNumber.Substring(2));

            return table[index].ppn;
        }

        /// <summary>
        /// Load a buch of stuffs into the TLB.
        /// </summary>
        /// <param name="rows"></param>
        public void LoadPageTableData(string[] rows)
        {
            for (int i = 0; i < rows.Length; i++)
                table.Add(new PTRow(rows[i]));
        }

    }

    /// <summary>
    /// Every entry in the page table is a PTRow
    /// </summary>
    public class PTRow
    {

        /// <summary>
        /// ppn is the physical page number where the data is stored.
        /// </summary>
        public string ppn { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="ppn"></param>
        public PTRow(string ppn)
        {
            this.ppn = ppn;
        }

    }

}
