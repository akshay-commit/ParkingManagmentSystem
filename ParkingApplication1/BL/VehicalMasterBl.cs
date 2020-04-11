using ParkingApplication1.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParkingApplication1.BL
{
    public class VehicalMasterBl
    {
          string Vehicletype;
    int TotalAllotedSlots;

    public string Vehicletype1   // property
    {
        get { return Vehicletype; }   // get method
        set { Vehicletype = value; }  // set method
    }
    public int TotalAllotedSlots1   // property
    {
        get { return TotalAllotedSlots; }   // get method
        set { TotalAllotedSlots = value; }  // set method
    }

    public int InsertVehicleType()
    {
        int i = 0;
        DAL odl = new DAL();
        string Query = "Insert into VehicleTypeMaster Values('" + Vehicletype + "'," + TotalAllotedSlots + ")";
       i=  odl.Insert(Query);
       return i;    
    }
    public int UpdateVehicleType()
    {
        int i = 0;
        DAL odl = new DAL();
        string Query = "Update into VehicleTypeMaster Values('" + Vehicletype + "'," + TotalAllotedSlots + ")";
       // i = odl.up(Query);
        return i;
    }
    public int DeleteVehicleType()
    {
        int i = 0;
        DAL odl = new DAL();
        string Query = "Insert into VehicleTypeMaster Values('" + Vehicletype + "'," + TotalAllotedSlots + ")";
        //i = odl.de(Query);
        return i;
    }

   }
    }
