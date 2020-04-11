using ParkingApplication1.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingApplication1
{
    public partial class VehicalInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropdown();
            }
        }

        private void FillDropdown()
        {
            DataSet dsddl = new DataSet();
            VehicalnfoBL objvinfo = new VehicalnfoBL();
            dsddl=objvinfo.SelectVehicleType();
            if (dsddl != null)
            {

                DropdwnVtype.DataTextField = dsddl.Tables[0].Columns["Vehicletype"].ToString(); // text field name of table dispalyed in dropdown
                DropdwnVtype.DataValueField = dsddl.Tables[0].Columns["VehicleTypeId"].ToString();             // to retrive specific  textfield name 
                DropdwnVtype.DataSource = dsddl.Tables[0];      //assigning datasource to the dropdownlist
                DropdwnVtype.DataBind();  //binding dropdownlist
            
            }

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int totAvilSlots = 0;
            DataSet ds = new DataSet();
            VehicalnfoBL oVehicalnfoBL = new VehicalnfoBL();
           int vehicleid= Convert.ToInt32(DropdwnVtype.SelectedValue);
           ds=oVehicalnfoBL.SelectVehicleslots(vehicleid);
           if (ds != null)
           { 
              if(ds.Tables[0].Rows.Count>0)
               {
                    totAvilSlots = Convert.ToInt32(ds.Tables[0].Rows[0]["Noof_Slots"]);
               }
           
           }
           oVehicalnfoBL.VehicleTypeId1 = vehicleid;       
            int slotfrom = Convert.ToInt32(txtFrom.Text);
            int slotto = Convert.ToInt32(txtTo.Text);
            int totalslots = slotto - slotfrom;
            if (totAvilSlots < (totalslots+1))
            {
                Response.Write("You can not assign slots more than its avilability");
            }
            else
            {
                int j=0;
                for (int i = slotfrom; i <= slotto;i++ )
                {
                    oVehicalnfoBL.Allotedslots1 = i;
                     j= oVehicalnfoBL.InsertVehicleType();

                }
                
                if (j > 0)
                {
                    Response.Write("Data inserted successfully");

                }
            }
        }

        protected void DropdwnVtype_SelectedIndexChanged(object sender, EventArgs e)
        {
           // FillDropdown();
        }
    }
}