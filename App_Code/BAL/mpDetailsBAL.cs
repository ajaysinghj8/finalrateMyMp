﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


public class mpDetailsBAL
{
    mpDetailsDAL mpDetailsDAL = new mpDetailsDAL();
	public mpDetailsBAL()
	{
        //constructor
	}
    public DataTable getData(Int16 constituencyId)
    {
        try
        {
            return mpDetailsDAL.getData(constituencyId);
        }
        catch
        {
            throw;
        }
        finally
        {
        }
    }
    public bool saveMpDetails(userMasterBO userMasterBO,mpDetailsBO mpDetailsBO)
    {
        try
        {
           return mpDetailsDAL.saveMpDetails(userMasterBO,mpDetailsBO);
        }
        catch
        {
            throw;
        }
        finally
        {

        }
    }
    public DataTable loadDistrict(byte stateId)
    {
        try
        {
            return mpDetailsDAL.loadDistrict(stateId);
        }
        catch
        {
            throw;
        }
        finally
        {

        }
    }
    public DataTable loadConstituency(byte stateId)
    {
        try
        {
            return mpDetailsDAL.loadConstituency(stateId);
        }
        catch
        {
            throw;
        }
        finally
        {

        }
    }
    public DataTable loadParty(int countryId)
    {
        try
        {
            return mpDetailsDAL.loadParty(countryId);
        }
        catch
        {
            throw;
        }
        finally
        {

        }
    }

    public DataTable loadState(int countryId)
    {
        try
        {
            return mpDetailsDAL.loadState(countryId);
        }
        catch
        {
            throw;
        }
        finally
        {

        }
    }
    public DataTable loadCountry()
    {
      
        try
        {
           return mpDetailsDAL.loadCountry();
        }
        catch
        {
            throw;
        }
        finally
        {

        }
    }

}