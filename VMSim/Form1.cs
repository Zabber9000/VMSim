using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMSim.Models;
using Microsoft.VisualBasic;

namespace VMSim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MemoryManager mm = new MemoryManager();


        private void Form1_Load(object sender, EventArgs e)
        {

            // Load mock data for page table.
            mm.pt.LoadPageTableData(Mockdata.PTMockdata.PTData);

            // Load mock data for page table.
            mm.tlb.LoadPageTableData(Mockdata.PTMockdata.TBLData);

            // Load mock data into the combobox.
            for (int i = 0; i < mm.pt.PTMaxSize; i++)
                cbxAllAdresses.Items.Add("0x" + i.ToString().PadLeft(5, '0'));

            // Resfresh the TLB.
            RefreshTLB();

            // Resfresh the page table.
            RefreshPT();

        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshTLB()
        {
            lbxTLB.Items.Clear();
            lbxTLB.Items.AddRange(mm.GetTLBArray());
        }

        /// <summary>
        /// 
        /// </summary>
        private void RefreshPT()
        {
            lbxPT.Items.Clear();
            lbxPT.Items.AddRange(mm.GetPTArray());
        }

        private void GetPhysicalPageNumber(object sender, EventArgs e)
        {

            // Validate the virtual page selection.
            if (cbxAllAdresses.SelectedIndex == -1)
            {
                MessageBox.Show("Select virtual page number.");
                return;
            }

            string virtualAddress = cbxAllAdresses.Text + txtOffset.Text;

            txtVirtualAddress.Text = virtualAddress;

            MemoryAddress pa = mm.GetPhysicalAddress(virtualAddress);

            txtPhysicalAddress.Text = pa.ToString();

            RefreshTLB();

            RefreshPT();

        }
    }

}
