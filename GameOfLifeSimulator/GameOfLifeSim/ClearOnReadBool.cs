﻿/***********************************************************************************************************************
***********************************************************************************************************************/

namespace GameOfLifeSim
{
  /*********************************************************************************************************************
  *********************************************************************************************************************/
  internal class ClearOnReadBool
  {
    private bool value;

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void Set()
    {
      value=true;
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public bool Value
    {
      get
      {
        var retval=value;
        value=false;
        return retval;
      }
    }
  }
}

// EOF *****************************************************************************************************************