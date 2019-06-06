/***********************************************************************************************************************
***********************************************************************************************************************/
using System;
using System.Threading;
using System.Windows.Forms;

namespace GameOfLifeSim
{
  /*********************************************************************************************************************
  *********************************************************************************************************************/
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private static void Main()
    {
      try
      {
        Application.ThreadException+=ApplicationOnThreadException;
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
      }
      catch(Exception ex)
      {
        MessageBox.Show($@"Application startup error, error is: {ex}",@"STARTUP ERROR",MessageBoxButtons.OK,
          MessageBoxIcon.Error);
      }
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private static void ApplicationOnThreadException(object sender,ThreadExceptionEventArgs e)
    {
      if(MessageBox.Show($@"Application error, error is {e.Exception}. Do you want to terminate the program?",
           @"APPLICATION ERROR",MessageBoxButtons.YesNo,MessageBoxIcon.Error)==DialogResult.Yes)
      {
        Application.Exit();
      }
    }
  }
}

// EOF *****************************************************************************************************************
