using ParkingApplication1.BL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkingApplication1
{
    public partial class VehicalParking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillDropdown();
                BindGrid();
                
            }
        }

        private void BindGrid()
        {
            DataSet dsddl = new DataSet();
            VehicalParkingBL oVehicalParkingBL = new VehicalParkingBL();
            dsddl = oVehicalParkingBL.SelectParkingdata();
            if (dsddl != null)
            {
                if (dsddl.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = dsddl.Tables[0];
                    GridView1.DataBind();
                }
                GridView1.DataBind();
            }
        }

        private void SearchVehicle()
        {
            DataSet dsddl = new DataSet();
            VehicalParkingBL oVehicalParkingBL = new VehicalParkingBL();
            oVehicalParkingBL.VehicleNo1 = txtserch.Text;
            dsddl = oVehicalParkingBL.SearchParkingdata();
            if (dsddl != null)
            {
                if (dsddl.Tables[0].Rows.Count > 0)
                {
                    GridView1.DataSource = dsddl.Tables[0];
                    GridView1.DataBind();
                }
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            VehicalParkingBL oVehicleMasterBL = new VehicalParkingBL();
            oVehicleMasterBL.VehicleNo1 = txtVeNO0.Text;
            oVehicleMasterBL.VehicleTypeId1 = Convert.ToInt32(drpdVtype.SelectedValue);
            oVehicleMasterBL.AllotedSlot1 = Convert.ToInt32(drpAviSlot.SelectedValue);
            oVehicleMasterBL.InsertVehicleParking();
            {
                Response.Write("Data inserted successfully");
                txtVeNO0.Text = "";
                drpAviSlot.Items.Clear();
                BindGrid();
            }
        }

        protected void drpdVtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vid = Convert.ToInt32(drpdVtype.SelectedValue);
            FillSlots(vid);
        }

        private void FillSlots(int vehicletypeId)
        {
            DataSet dsddl = new DataSet();
            VehicalnfoBL objvinfo = new VehicalnfoBL();
            dsddl = objvinfo.SelectVehicleslots(vehicletypeId);
            if (dsddl != null)
            {

                drpAviSlot.DataTextField = dsddl.Tables[0].Columns["SlotId"].ToString(); // text field name of table dispalyed in dropdown
                drpAviSlot.DataValueField = dsddl.Tables[0].Columns["Slot_No"].ToString();             // to retrive specific  textfield name 
                drpAviSlot.DataSource = dsddl.Tables[0];      //assigning datasource to the dropdownlist
                drpAviSlot.DataBind();  //binding dropdownlist

            }


        }
        private void FillDropdown()
        {
            DataSet dsddl = new DataSet();
            VehicalnfoBL objvinfo = new VehicalnfoBL();
            dsddl = objvinfo.SelectVehicleType();
            if (dsddl != null)
            {

                drpdVtype.DataTextField = dsddl.Tables[0].Columns["Vehicletype"].ToString(); // text field name of table dispalyed in dropdown
                drpdVtype.DataValueField = dsddl.Tables[0].Columns["VehicleTypeId"].ToString();             // to retrive specific  textfield name 
                drpdVtype.DataSource = dsddl.Tables[0];      //assigning datasource to the dropdownlist
                drpdVtype.DataBind();  //binding dropdownlist

            }
            drpdVtype.Items.Insert(0, new ListItem("--Select Vehicletype--", "0"));

        }


        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                //Determine the RowIndex of the Row whose LinkButton was clicked.
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = GridView1.Rows[rowIndex];

                //Fetch value of Name.
                //int name = Convert.ToInt32(e.Row.Cells[0].Text); 
                //string name = row.Cells[0].ToString();

                //Fetch value of Country
                string id = row.Cells[0].Text;
                VehicalParkingBL oVehicalParkingBL = new VehicalParkingBL();
                oVehicalParkingBL.ParkingId1 = Convert.ToInt32(id);
               int j= oVehicalParkingBL.ExitSlot();
               if (j > 0)
               {
                   Response.Write("Vehicle is Exit succssefully");
                   BindGrid();
               }
               // ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Name: " + name + "\\nCountry: " + country + "');", true);

            }
        }

        protected void GridView1_SelectedIndexChanged2(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SearchVehicle();
        }

     
            
    }
}
