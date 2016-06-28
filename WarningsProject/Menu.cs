using System;
using System.Collections.Generic;
using System.Text;
using SAPbouiCOM.Framework;
using SAPbouiCOM;

namespace WarningsProject
{
    class Menu
    {
        private SAPbouiCOM.Application UIApp = SAPbouiCOM.Framework.Application.SBO_Application;
        
        public void SBO_Application_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

                ContextMenu contextMenu = ContextMenu.GetObj;
                if ( pVal.BeforeAction )
                {
                    
                    if ( pVal.MenuUID == "3591" )
                    {
                        contextMenu.Clear();
                        contextMenu.CreateMenu(string.Format("Учет запчастей/расходников и краски"));
                    }

                    if (pVal.MenuUID == "subMenu0")
                    {
                        // Заполнение формы, которая сейчас откроется
                        string id = ((SAPbouiCOM.EditText)UIApp.Forms.ActiveForm.Items.Item("lab2").Specific).Value;
                        dataFromOINS a = AdoNetQueries.GetEqCard(id);

                        contextMenu.Clear();

                        var f = new Form1(a);
                        f.Show();
                        //var f = new UDOForm2(a.internalSN, a.custmrName, a.itemName);
                    }
                }
                
           
        }

    }
}
