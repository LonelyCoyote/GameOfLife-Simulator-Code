/***********************************************************************************************************************
***********************************************************************************************************************/
using DDBDrawingLib;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GameOfLifeSim
{
  /*********************************************************************************************************************
  *********************************************************************************************************************/
  internal sealed class GameOfLifeWorld:CellWorld
  {
    public readonly Canvas theWorld;
    private readonly List<Cell> BirthCells=new List<Cell>();
    public readonly CellWorld NewPattern;
    
    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public GameOfLifeWorld(Canvas world):base(Color.DeepSkyBlue)
    {
      theWorld=world;
      NewPattern=new CellWorld(Color.Violet);
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void AddNewPatternToWorld()
    {
      Cells.AddRange(NewPattern.Cells);
      NewPattern.Cells.Clear();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void Draw()
    {
      theWorld.Clear();
      Cells.ForEach(x=>x.Draw(theWorld));
      NewPattern.Cells.ForEach(x=>x.Draw(theWorld));
      theWorld.BitMapToCanvas();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void ToggleCellAtPosition(int x,int y)
    {
      ToggleAtPosition(x,y,this);
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void ToggleNewPatternAtPosition(int x,int y)
    {
      ToggleAtPosition(x,y,NewPattern);
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void ToggleAtPosition(int x,int y,CellWorld world)
    {
      var pos = world.Cells.FindIndex(c => c.x==x&&c.y==y);
      if(pos<0)
      {
        world.Cells.Add(new Cell(x,y,world.CellColor));
      }
      else
      {
        world.Cells.RemoveAt(pos);
      }
      Draw();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public void AdvanceTimeOneClick()
    {
      Cells.ForEach(ProcessCell);
      Cells.RemoveAll(x=>x.MarkedForDeath); // Remove dead cells
      Cells.AddRange(BirthCells);
      BirthCells.Clear();
      Draw();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void ProcessCell(Cell c)
    {
      var cellCount=GetNeighborCellCountAndHandleBirths(c);

      // Conways game of life rules, the cell dies if it does not have 2-3 neighbors
      if(cellCount<2||cellCount>3)
      {
        c.MarkedForDeath=true;
      }
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private int GetNeighborCellCountAndHandleBirths(Cell c)
    {
      var retval=0;

      for(var y=c.y-1;y<=c.y+1;y++)
      {
        for(var x=c.x-1;x<=c.x+1;x++)
        {
          if(c.x==x&&c.y==y) continue;
          if(Cells.Exists(e=>e.x==x&&e.y==y))
          {
            //if(retval==4) continue; // Optimization attempt, did not notice any improvement in performance
            retval++;
          }
          else
          {
            CheckForBirth(x,y);
          }
        }
      }

      return retval;
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void CheckForBirth(int px,int py)
    {
      if(BirthCells.Any(bc=>bc.x==px&&bc.y==py)) return;  // Already in birth list
      
      var count=0;
      for(var y = py-1;y<=py+1;y++)
      {
        for(var x = px-1;x<=px+1;x++)
        {
          if(px==x&&py==y) continue;
          if(!Cells.Exists(e=>e.x==x&&e.y==y)) continue;
          //if(count==3) return;  // Optimization attempt, did not notice any improvement in performance
          count++;
        }
      }

      if(count==3)  // Conways game of life requires exactly three neighbor cells be present for a birth
      {
        BirthCells.Add(new Cell(px,py));
      }
    }

  }
}

// EOF *****************************************************************************************************************
