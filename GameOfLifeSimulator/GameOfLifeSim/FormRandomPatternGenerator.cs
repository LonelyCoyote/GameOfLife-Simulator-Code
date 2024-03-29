﻿/***********************************************************************************************************************
***********************************************************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLifeSim
{
  /*********************************************************************************************************************
  *********************************************************************************************************************/
  internal partial class FormRandomPatternGenerator:Form
  {
    public readonly CellWorld theCellWorld=new CellWorld(Color.GreenYellow);
    
    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public FormRandomPatternGenerator()
    {
      InitializeComponent();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void OnOK(object sender,EventArgs e)
    {
      var x=(int)ncLength.Value;
      var y=(int)ncWidth.Value;
      var chance=(int)ncPercentProbability.Value;
      GenerateRandomCellWorld(x,y,chance);
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void GenerateRandomCellWorld(int xmax,int ymax,int chance)
    {
      theCellWorld.Cells.Clear();
      var r=new Random(DateTime.Now.Millisecond);
      for(var x=0;x<xmax;x++)
      {
        for(var y=0;y<ymax;y++)
        {
          GenerateRandomCell(x,y,chance,r);
        }
      }
      theCellWorld.NormalizeWorld();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void GenerateRandomCell(int x,int y,int chance,Random r)
    {
      var c=r.Next(100);
      if(c>chance) return;
      theCellWorld.Cells.Add(new Cell(x,y,Color.DeepPink));
    }
  }
}

// EOF *****************************************************************************************************************

