/**********************************************************************************************************************
**********************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DDBDrawingLib;

namespace GameOfLifeSim
{
  /********************************************************************************************************************
  ********************************************************************************************************************/
  internal partial class Form1:Form
  {
    private readonly GameOfLifeWorld theGameOfLifeWorld;
    private enum Mode{CreateWorld,SimWorld,CreatePattern,PlacePattern}

    private PointF MouseDownStartPoint;
    private Mode ActiveMode=Mode.CreateWorld;

    private readonly FormPatterns thePatternsForm;

    private List<Cell> PatternToPlace=new List<Cell>();
    private readonly ClearOnReadBool RotateEvent=new ClearOnReadBool();
    private readonly ClearOnReadBool MirrorEvent=new ClearOnReadBool();

    /******************************************************************************************************************
    ******************************************************************************************************************/
    public Form1()
    {
      InitializeComponent();
      theGameOfLifeWorld=new GameOfLifeWorld(new Canvas(pbWorld,Color.Black));
      theGameOfLifeWorld.Draw();
      MouseWheel+=OnMouseWheel;
      miCreateWorld.Checked=true;
      tmrUpdateScreen.Enabled=true;
      thePatternsForm=new FormPatterns();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnMouseWheel(object sender,MouseEventArgs e)
    {
      var ticks=e.Delta;
      if(ticks==0) return;
      if(ticks>0) theGameOfLifeWorld.theWorld.GrowView(); else theGameOfLifeWorld.theWorld.NarrowView();
      theGameOfLifeWorld.Draw();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnSizeChanged(object sender,System.EventArgs e)
    {
      theGameOfLifeWorld.theWorld.CanvasSizeChanged();
      theGameOfLifeWorld.Draw();

    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnMouseMove(object sender,MouseEventArgs e)
    {
      if(e.Button!=MouseButtons.Left) return;
        var delta = new PointF(e.X-MouseDownStartPoint.X,e.Y-MouseDownStartPoint.Y);
        theGameOfLifeWorld.theWorld.MoveWorldPoint(delta);
        MouseDownStartPoint.X=e.X; MouseDownStartPoint.Y=e.Y;
        theGameOfLifeWorld.Draw();
        Invalidate();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnMouseButtonDown(object sender,MouseEventArgs e)
    {
      if(e.Button==MouseButtons.Left)
      {
        MouseDownStartPoint=new PointF(e.X,e.Y);
      }
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnCreateWorld(object sender,System.EventArgs e)
    {
      ActiveMode=Mode.CreateWorld;
      miCreateWorld.Checked=true;
      miSimWorld.Checked=false;
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnDoubleClick(object sender,System.EventArgs e)
    {
      switch(ActiveMode)
      {
        case Mode.SimWorld:
          return;
        case Mode.CreateWorld:
          DoubleClickCreateWorld();
          return;
        case Mode.CreatePattern:
          DoubleClickCreatePattern();
          return;
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void DoubleClickCreateWorld()
    {
      var xyPosition=GetXYCellFromMousePosition();
      theGameOfLifeWorld.ToggleCellAtPosition(xyPosition.Item1,xyPosition.Item2);
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void DoubleClickCreatePattern()
    {
      var xyPosition=GetXYCellFromMousePosition();
      theGameOfLifeWorld.ToggleNewPatternAtPosition(xyPosition.Item1,xyPosition.Item2);
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private Tuple<int,int> GetXYCellFromMousePosition()
    {
      var pxlPosition = pbWorld.PointToClient(MousePosition);
      var worldPosition = theGameOfLifeWorld.theWorld.PixelPointToWorldPoint(pxlPosition);
      var xyPosition = Cell.GetXYPositionFromWorldPoint(worldPosition);
      return xyPosition;
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnSimWorld(object sender,System.EventArgs e)
    {
      ActiveMode=Mode.SimWorld;
      miCreateWorld.Checked=false;
      miSimWorld.Checked=true;
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnUpdateScreen(object sender,System.EventArgs e)
    {
      switch(ActiveMode)
      {
        case Mode.SimWorld:
          SimWorld();
          return;
        case Mode.PlacePattern:
          PlacePattern();
          return;
      }
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void SimWorld()
    {
      theGameOfLifeWorld.AdvanceTimeOneClick();
      var popSize = theGameOfLifeWorld.PopulationSize;
      Text=$@"Population Size: {popSize}";
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void PlacePattern()
    {
      var pos=GetXYCellFromMousePosition();
      if(pos==null)
      {
        theGameOfLifeWorld.NewPattern.Cells.Clear();
        theGameOfLifeWorld.Draw();
        return;
      }

      if(RotateEvent.Value) RotatePattern(PatternToPlace);
      if(MirrorEvent.Value) MirrorPattern(PatternToPlace);

      var selPattern=new List<Cell>(PatternToPlace);
      var newCells=selPattern.Select(c=>new Cell(c.x+pos.Item1,c.y+pos.Item2)).ToList();

      theGameOfLifeWorld.NewPattern.Cells.Clear();
      theGameOfLifeWorld.NewPattern.Cells.AddRange(newCells);
      theGameOfLifeWorld.Draw();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void RotatePattern(List<Cell> p)
    {
      p.ForEach(SwapXY);
      p.ForEach(c=>c.y=-c.y);
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private static void SwapXY(Cell p)
    {
      var t=p.x;
      p.x=p.y;
      p.y=t;
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void MirrorPattern(List<Cell> p)
    {
      p.ForEach(c=>c.x=-c.x);
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnLoadWorld(object sender,EventArgs e)
    {
      var fd=new OpenFileDialog {AddExtension=true,DefaultExt="csv"};
      if(fd.ShowDialog()!=DialogResult.OK) return;
      theGameOfLifeWorld.LoadWorld(fd.FileName);
      theGameOfLifeWorld.Draw();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnSaveWorld(object sender,EventArgs e)
    {
      var fd=new SaveFileDialog{AddExtension=true,DefaultExt="csv"};
      if(fd.ShowDialog()!=DialogResult.OK) return;
      theGameOfLifeWorld.SaveWorld(fd.FileName);
      theGameOfLifeWorld.Draw();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnMenuPatterns(object sender,EventArgs e)
    {
      if(ActiveMode==Mode.SimWorld) return; // Ignore request when simulating world
      thePatternsForm.ShowDialog();
      if(thePatternsForm.CreateModeActive) ActiveMode=Mode.CreatePattern;
      if(thePatternsForm.AddToWorldModeActive)
      {
        ActiveMode=Mode.PlacePattern;
        PatternToPlace=new List<Cell>(thePatternsForm.SelectedCellWorld.Cells);
      }
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnSingleClick(object sender,MouseEventArgs e)
    {
      if(e.Button!=MouseButtons.Right) return;
      if(ActiveMode==Mode.CreatePattern)
      {
        CompleteCreatePatternOperation();
      }

      if(ActiveMode==Mode.PlacePattern)
      {
        CompletePlacePatternOperation();
      }
      theGameOfLifeWorld.Draw();
      ActiveMode=Mode.CreateWorld;
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void CompletePlacePatternOperation()
    {
      theGameOfLifeWorld.AddNewPatternToWorld();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void CompleteCreatePatternOperation()
    {
      if(!theGameOfLifeWorld.NewPattern.Cells.Any())
      {
        ActiveMode=Mode.CreateWorld;
        return;
      }
      thePatternsForm.AddNewPattern(theGameOfLifeWorld.NewPattern);
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnKeyPress(object sender,KeyPressEventArgs e)
    {
      if(ActiveMode!=Mode.PlacePattern) return;
      var key=e.KeyChar.ToString().ToUpper();
      switch(key)
      {
        case "R":
          RotateEvent.Set();
          break;
        case "M":
          MirrorEvent.Set();
          break;
        default:
          return;
      }
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnFormClosing(object sender,FormClosingEventArgs e)
    {
      thePatternsForm.Close();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnClearScreen(object sender,EventArgs e)
    {
      theGameOfLifeWorld.Cells.Clear();
      theGameOfLifeWorld.Draw();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnGenerateRandomPattern(object sender,EventArgs e)
    {
      if(ActiveMode!=Mode.CreateWorld) return;
      var frm=new FormRandomPatternGenerator();
      if(frm.ShowDialog()!=DialogResult.OK) return;

      ActiveMode=Mode.PlacePattern;
      PatternToPlace=new List<Cell>(frm.theCellWorld.Cells);
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnChangeFrameTime(object sender,EventArgs e)
    {
      var tickTime=tmrUpdateScreen.Interval;
      var dialog=new FormFrameTime {FrameTime=tickTime};
      if(dialog.ShowDialog()!=DialogResult.OK) return;
      tmrUpdateScreen.Interval=dialog.FrameTime;
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnHelpAbout(object sender,EventArgs e)
    {
      var aboutDialog=new FormHelpAbout();
      aboutDialog.ShowDialog();
    }

    /******************************************************************************************************************
    ******************************************************************************************************************/
    private void OnHelpIntructions(object sender,EventArgs e)
    {
      var instructions=new FormHelp();
      instructions.Show();
      
    }
  }
}

// EOF *****************************************************************************************************************
