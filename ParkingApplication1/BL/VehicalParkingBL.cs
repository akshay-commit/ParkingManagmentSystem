using ParkingApplication1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace ParkingApplication1.BL
{
    public class VehicalParkingBL
    {
        string VehicleNo;
        int VehicleTypeId, ParkingId;
        int AllotedSlot;

        public int ParkingId1   // property
        {
            get { return ParkingId; }   // get method
            set { ParkingId = value; }  // set method
        }
        public string VehicleNo1   // property
        {
            get { return VehicleNo; }   // get method
            set { VehicleNo = value; }  // set method
        }
        public int VehicleTypeId1   // property
        {
            get { return VehicleTypeId; }   // get method
            set { VehicleTypeId = value; }  // set method
        }

        public int AllotedSlot1   // property
        {
            get { return AllotedSlot; }   // get method
            set { AllotedSlot = value; }  // set method
        }
        public int InsertVehicleParking()
        {
            int i = 0;
            DAL odl = new DAL();
            string Query = "Insert into VehicalParkingImfo Values('" + VehicleTypeId + "'," + AllotedSlot + ",'" + VehicleNo + "',0)";
            i = odl.Insert(Query);
            return i;
        }
        public int UpdateVehicleType()
        {
            int i = 0;
            DAL odl = new DAL();
            string Query = "Update into VehicleTypeMaster Values('" + VehicleTypeId + "'," + AllotedSlot + ",'" + VehicleNo + "')";
            return i;
        }
        public int ExitSlot()
        {
            int i = 0;
            DAL odl = new DAL();
            string Query = "update VehicalParkingImfo set IsExit=1 where ParkingId="+ParkingId+"";
            i = odl.Insert(Query);
            return i;
        }
        public DataSet SelectParkingdata()
        {
            //DL odl = new DL();
            int i = 0;
            DataSet ds = new DataSet();
            DAL odal = new DAL();
            string Query = "Select vp.ParkingId,vp.VehicleNo,vm.Vehicletype,vp.AllotedSlot " + 
                           "from VehicleTypeMaster vm inner join "+
                           "VehicalParkingImfo vp on vm.VehicleTypeId=vp.VehicleTypeId where IsExit=0";
            ds = odal.GET(Query);
            return ds;
        }
        public DataSet SearchParkingdata()
        {
            //DL odl = new DL();
            int i = 0;
            DataSet ds = new DataSet();
            DAL odal = new DAL();
            string Query = "Select vp.ParkingId,vp.VehicleNo,vm.Vehicletype,vp.AllotedSlot " +
                           "from VehicleTypeMaster vm inner join " +
                           "VehicalParkingImfo vp on vm.VehicleTypeId=vp.VehicleTypeId where IsExit=0 and VehicleNo='"+VehicleNo1+"'";
            ds = odal.GET(Query);
            return ds;
        }
    }
}