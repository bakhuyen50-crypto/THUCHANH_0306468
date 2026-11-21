using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace hello_World
{
        [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
        public class helloWorld : IExternalCommand
        {
            public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
            {                         
                UIDocument uidoc = commandData.Application.ActiveUIDocument;
                ICollection<ElementId> selectedIds = uidoc.Selection.GetElementIds();
                int totalCount = selectedIds.Count;
                MessageBox.Show("Ban da chon" + totalCount.ToString() + " phan tu");
            return Result.Succeeded;
            }
        }
}