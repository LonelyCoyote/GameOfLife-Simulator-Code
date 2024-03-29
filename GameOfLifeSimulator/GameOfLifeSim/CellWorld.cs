﻿/***********************************************************************************************************************
***********************************************************************************************************************/
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;

namespace GameOfLifeSim
{
  /*********************************************************************************************************************
  *********************************************************************************************************************/
  internal class CellWorld
  {
    public readonly List<Cell> Cells = new List<Cell>();
    public readonly Color CellColor;

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public CellWorld(Color c)
    {
      CellColor=c;
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public CellWorld(CellWorld cpy)
    {
      CellColor=cpy.CellColor;
      Cells=new List<Cell>(cpy.Cells);
      Name=cpy.Name;
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public int PopulationSize=>Cells.Count;

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public string Name{get;set;}

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void LoadWorld(string fileName)
    {
      using(var f = File.OpenText(fileName))
      {
        Cells.Clear();
        while(!f.EndOfStream)
        {
          var line = f.ReadLine();
          if(line==null) continue;
          if(line==string.Empty) continue;
          var parts = line.Split(',');
          if(parts.Length!=2)
          {
            if(parts.Length==1) Name=parts[0];
            continue;
          }
          if(!int.TryParse(parts[0],NumberStyles.Integer,null,out var x)) continue;
          if(int.TryParse(parts[1],NumberStyles.Integer,null,out var y))
          {
            Cells.Add(new Cell(x,y));
          }
        }
      }
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void SaveWorld(string fileName)
    {
      NormalizeWorld();
      using(var f = File.CreateText(fileName))
      {
        f.WriteLine(Name);
        Cells.ForEach(c => SaveXYLocationToFile(f,c));
      }
    }

    /*******************************************************************************************************************
    // Centers a world around the x and y axis to ease rotation, and reflection along x or y axis
    *******************************************************************************************************************/
    public void NormalizeWorld()
    {
      var xmin = Cells.Min(c => c.x);
      var xmax = Cells.Max(c => c.x);
      var xmov = -(xmin+xmax)/2;
      var ymin = Cells.Min(c => c.y);
      var ymax = Cells.Max(c => c.y);
      var ymov = -(ymin+ymax)/2;
      Cells.ForEach(c => { c.x+=xmov; c.y+=ymov; });
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private static void SaveXYLocationToFile(TextWriter f,Cell c)
    {
      f.WriteLine("{0},{1}",c.x,c.y);
    }
  }
}

// EOF *****************************************************************************************************************
