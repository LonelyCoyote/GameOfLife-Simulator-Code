/***********************************************************************************************************************
***********************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameOfLifeSim
{
  /*********************************************************************************************************************
  *********************************************************************************************************************/
  public partial class FormName:Form
  {
    private readonly List<string> UsedNames;

    /*********************************************************************************************************************
    *********************************************************************************************************************/
    public FormName(List<string> usedNames)
    {
      InitializeComponent();
      UsedNames=usedNames;
    }

    public string PatternName=>tbName.Text;

    /*********************************************************************************************************************
    *********************************************************************************************************************/
    private void OnTextChanged(object sender,EventArgs e)
    {
      tbName.CharacterCasing=CharacterCasing.Upper;
      if(tbName.Text==string.Empty)
      {
        btnOK.Enabled=false;
        return;
      }

      if(UsedNames.Contains(tbName.Text))
      {
        btnOK.Enabled=false;
        return;
      }

      btnOK.Enabled=true;
    }
  }
}
