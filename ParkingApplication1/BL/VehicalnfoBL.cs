using ParkingApplication1.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ParkingApplication1.BL
{
    public class VehicalnfoBL
    {
        int VehicleTypeId, Allotedslots;
        string Vehicletype;


        public string Vehicletype1   // property
        {
            get { return Vehicletype; }   // get method
            set { Vehicletype = value; }  // set method
        }
        public int VehicleTypeId1   // property
        {
            get { return VehicleTypeId; }   // get method
            set { VehicleTypeId = value; }  // set method
        }
        public int Allotedslots1  // property
        {
            get { return Allotedslots; }   // get method
            set { Allotedslots = value; }  // set method
        }   
        public int InsertVehicleType()
        {
            int i = 0;
            DAL odal = new DAL();
            string Query = "Insert into dbo.SlotMaster Values('" + Allotedslots1 + "'," + VehicleTypeId1 + ")";
            i = odal.Insert(Query);
            return i;
        }

        public int UpdateVehicleType()
        {
            int i = 0;
            DAL odal = new DAL();
            string Query = "Update into VehicleTypeMaster Values('" + Vehicletype + "'," + Allotedslots + ")";
            // i = odl.up(Query);
            return i;
        }
        public int DeleteVehicleType()
        {
            int i = 0;
            DAL odal = new DAL();
            string Query = "Insert into VehicleTypeMaster Values('" + Vehicletype + "'," + Allotedslots + ")";
            //i = odl.de(Query);
            return i;
        }

        public DataSet SelectVehicleType()
        {
            //DL odl = new DL();
            int i = 0;      
            DataSet ds = new DataSet();
            DAL odal = new DAL();
            string Query = "Select VehicleTypeId,Vehicletype From VehicleTypeMaster";
            ds = odal.GET(Query);
            return ds;
        }
        public DataSet SelectVehicleType(int vehicleId)
        {
            //DL odl = new DL();
            int i = 0;
            DataSet ds = new DataSet();
            DAL odal = new DAL();
            string Query = "Select SlotId,Slot_No From SlotMaster where VehicleTypeId=" + vehicleId + "";
            ds = odal.GET(Query);
            return ds;
        }
        public DataSet SelectVehicleslots(int vehicleId)
        {
            //DL odl = new DL();
            int i = 0;
            DataSet ds = new DataSet();
            DAL odal = new DAL();
            string Query = "select Slot_No,SlotId from dbo.SlotMaster where Slot_No not in(select AllotedSlot from VehicalParkingImfo where IsExit=0) and VehicleTypeId=" + vehicleId + "";
            ds = odal.GET(Query);
            return ds;
        }

    }
   
}