/***********************************************************************************************************************
***********************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GameOfLifeSim
{
  /*********************************************************************************************************************
  *********************************************************************************************************************/
  public partial class FormPatterns:Form
  {
    private readonly List<CellWorld> Patterns=new List<CellWorld>();
    private const string patternFileExtension="glp";
    
    /*******************************************************************************************************************
    *******************************************************************************************************************/
    public FormPatterns()
    {
      InitializeComponent();
      LoadPatternsFromDisk();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    internal void AddNewPattern(CellWorld pattern)
    {
      pattern.Name=GetNameFromUser();
      pattern.NormalizeWorld();
      Patterns.Add(new CellWorld(pattern));
      pattern.Cells.Clear();
      UpdatePatternList();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    internal CellWorld SelectedCellWorld
    {
      get
      {
        var index=lbPatterns.SelectedIndex;
        return index<0?new CellWorld(Color.AliceBlue):Patterns[index];
      }
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void UpdatePatternList()
    {
      lbPatterns.Items.Clear();
      Patterns.ForEach(x=>lbPatterns.Items.Add(x.Name));
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private string GetNameFromUser()
    {
      var usedNames=Patterns.Select(x=>x.Name).ToList();
      var getName=new FormName(usedNames);
      getName.ShowDialog();
      return getName.PatternName;
    }

    /*******************************************************************************************************************
    Clear on Read Booleans
    *******************************************************************************************************************/
    private readonly ClearOnReadBool _CreateModeActive=new ClearOnReadBool();
    public bool CreateModeActive=>_CreateModeActive.Value;

    private readonly ClearOnReadBool _AddToWorldModeActive=new ClearOnReadBool();
    public bool AddToWorldModeActive=>_AddToWorldModeActive.Value;

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void OnCreateNew(object sender,System.EventArgs e)
    {
      _CreateModeActive.Set();
      Close();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void OnAddToWorld(object sender,EventArgs e)
    {
      _AddToWorldModeActive.Set();
      Close();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void OnFormClosing(object sender,FormClosingEventArgs e)
    {
      SavePatternsBackToDisk();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void SavePatternsBackToDisk()
    {
      Patterns.ForEach(SavePatternBackToDisk);
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void SavePatternBackToDisk(CellWorld p)
    {
      var name=Path.ChangeExtension(p.Name,patternFileExtension);
      p.SaveWorld(name);
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void LoadPatternsFromDisk()
    {
      var names=Directory.GetFiles(Directory.GetCurrentDirectory()).Where(x=>Path.GetExtension(x)=="."+patternFileExtension);
      names=names.Select(Path.GetFileName);
      names.ToList().ForEach(LoadPatternFromDisk);
      UpdatePatternList();
    }

    /*******************************************************************************************************************
    *******************************************************************************************************************/
    private void LoadPatternFromDisk(string fileName)
    {
      var name=Path.GetFileNameWithoutExtension(fileName);
      var cw=new CellWorld(Color.AliceBlue) {Name=name};
      cw.LoadWorld(fileName);
      Patterns.Add(cw);
    }
  }
}
