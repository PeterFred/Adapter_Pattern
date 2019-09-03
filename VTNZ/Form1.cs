using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTNZClasses;

namespace VTNZForm
{
    public partial class Form1 : Form
    {
        VTNZ station;
        List<IService> orderList;

        public Form1() {  InitializeComponent();    }

        private void Form1_Load(object sender, EventArgs e)
        {
            station = new VTNZ("VTNZ North Harbour", "3-5 Saturn Place, Albany", "Mon-Fri 730am-5pm", "info@VTNZ.co.nz");
            orderList = new List<IService>();
                   
            station.addService(new InspectionWrap(50, "WoF Inspection"));
            station.addService(new InspectionWrap(200, "Modified Vehicle Checkup"));
            station.addService(new InspectionWrap(150, "Pre-Purchase Inspection"));
            station.addService(new InspectionWrap(210, "Vehicle Registration"));

            listBoxInspections.DataSource = station.ServiceList;
            listBoxInspections.DisplayMember = "ServiceDetails";

            loadLabelDetails();
        }

        private void loadLabelDetails()
        {
            labelMessage.Text = "Select the Inspection type";
            labelDetailsHeader.Text = "Details of Inspection Record";
            labelTotalPriceHeader.Text = "Total Price for all Inspections Requested";
            labelCountHeader.Text = "Total number of Inspections requested";
            labelHeadrer.Text = station.printDetails();
            labelDetails.Hide();            labelTotalPrice.Hide();            labelCount.Hide();
        }

        private void buttonRequestInspection_Click(object sender, EventArgs e)
        {
            labelDetails.Show();            labelTotalPrice.Show();            labelCount.Show();

            orderList.Add((IService)listBoxInspections.SelectedItem);
            labelCount.Text = orderList.Count.ToString();

            decimal cost = 0;
            string details = "";
            foreach (IService service in orderList)
            {
                cost += service.ServicePrice;
                details += (service.ServiceDetails).ToString() + Environment.NewLine;
            }
            labelDetails.Text = details;
            labelTotalPrice.Text = cost.ToString();
        }
    }
}
