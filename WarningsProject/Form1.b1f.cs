using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using System.Windows.Forms;

namespace WarningsProject
{
    [FormAttribute("WarningsProject.Form1", "Form1.b1f")]
    class Form1 : UserFormBase
    {
        private SAPbouiCOM.Application UIApp = SAPbouiCOM.Framework.Application.SBO_Application;
        private SAPbouiCOM.Form oForm;

        allFields[][] dataForMatrixes = new allFields[2][];

        int indexRow = 1;

        public Form1()
        {
        }

        //public Grid grid1 { get; set; }

        public Form1 ( dataFromOINS a )
        //public Form1(string sn, string bpName, string itemName, string itemCode, string bpCode, string createDate, string docEntry)
        {
            a.createDate = a.createDate.Substring(0, a.createDate.LastIndexOf(" "));

            EditText5.Value = a.internalSN;
            EditText3.Value = a.custmrName;
            EditText4.Value = a.itemName;

            EditText8.Value = a.customer;
            EditText10.Value = a.itemCode;
            EditText6.Value = a.createDate;

            EditText7.Value = a.docEntry;
            EditText9.Value = a.insID;
            
            dataForMatrixes = AdoNetQueries.whereFormIsOpenMatrix0(a.insID);
            //this.oForm = this.UIApp.Forms.ActiveForm;
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_0").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_5").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_7").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_8").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_9").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_10").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_12").Specific));
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_15").Specific));
            this.Matrix0.ValidateAfter += new SAPbouiCOM._IMatrixEvents_ValidateAfterEventHandler(this.Matrix0_ValidateAfter);
            this.Matrix0.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.Matrix0_ChooseFromListAfter);
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_17").Specific));
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_18").Specific));
            this.Matrix1 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_19").Specific));
            this.Matrix1.LinkPressedBefore += new SAPbouiCOM._IMatrixEvents_LinkPressedBeforeEventHandler(this.Matrix1_LinkPressedBefore);
            this.Matrix1.ChooseFromListBefore += new SAPbouiCOM._IMatrixEvents_ChooseFromListBeforeEventHandler(this.Matrix1_ChooseFromListBefore);
            this.Matrix1.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.Matrix1_ChooseFromListAfter);
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_21").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_22").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_24").Specific));
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("Item_25").Specific));
            this.LinkedButton5 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_26").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_27").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("Item_30").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_31").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.CancelBTN = ((SAPbouiCOM.Button)(this.GetItem("Item_32").Specific));
            this.CancelBTN.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.CancelBTN_ClickBefore);
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("docEntry").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_13").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("Item_20").Specific));
            this.PictureBox0 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_33").Specific));
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_34").Specific));
            this.Button3.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button3_ClickBefore);
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("Item_35").Specific));
            this.Button4.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button4_ClickBefore);
            this.Matrix1.Columns.Item("batch").Editable = false;
            this.oForm = this.UIApp.Forms.ActiveForm;
            this.OnCustomInitialize();
        }

        void UIApp_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            if (pVal.FormType == 65053)
            {
                if ((Matrix0.Columns.Item("photo").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value == "" || (Matrix0.Columns.Item("photo").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value == null)
                {
                    Button4.Item.Visible = false;
                }
                else
                {
                    Button4.Item.Visible = true;
                }
            }
            /*
            if ( pVal.EventType == SAPbouiCOM.BoEventTypes.et_KEY_DOWN )
            {
                Button0.Caption = "Обновить";
            }
            */
            BubbleEvent = true;
        }

        private void OnCustomInitialize()
        {
          //  this.LoadAfter += new SAPbouiCOM.Framework.FormBase.LoadAfterHandler(this.Form_LoadAfter);
            this.VisibleAfter += new VisibleAfterHandler(this.Form_VisibleAfter);
            UIApp.ItemEvent += UIApp_ItemEvent;
        }

        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.Matrix Matrix0;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.Matrix Matrix1;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.StaticText StaticText10;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.LinkedButton LinkedButton5;
        private SAPbouiCOM.StaticText StaticText11;
        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button CancelBTN;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText9;

        private SAPbouiCOM.PictureBox PictureBox0;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.Button Button4;

        public SAPbouiCOM.ChooseFromList CFL { get; set; }
        public SAPbouiCOM.Button B_ChoosefromList { get; set; }
        public string columnRow { get; set; }
        
        public struct allFields
        {
            public string code1;

            public string title;
            public string photo;
            public string serialNumber;
            public string articul;

            public string EAN;
            public string instDate;
            public string srokExpl;
            public string snDate;

            public string comment;
            public string warning;
            public string charact;
            public string modif;

            public string docEntry;
            public string lineId;

            public string batchNumber;
            public string createDate;
            public string shipingDate;

            public string insID;
            public string track;
        }

        // "Отменить"
        private void CancelBTN_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            //draw();
            //UIApp.Forms.ActiveForm.Close();
            BubbleEvent = true;
        }

        // Кнопка "Добавить"
        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            //bool a = Matrix0.Columns.Item("code1").Visible;

            if (Button0.Caption == "Добавить" || Button0.Caption == "Обновить")
            {
                if (Folder0.Selected)
                {
                    for (var i = 1; i < (Matrix0.RowCount + 1); i++)
                    {
                        allFields data = new allFields();
                        
                        data.code1 = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("code").Cells.Item(i).Specific).Value;
                        data.title = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("title").Cells.Item(i).Specific).Value;
                        data.photo = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("photo").Cells.Item(i).Specific).Value;
                        data.serialNumber = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("serialN").Cells.Item(i).Specific).Value;
                        data.articul = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("articul").Cells.Item(i).Specific).Value;
                        data.EAN = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("EAN").Cells.Item(i).Specific).Value;
                        data.instDate = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("instDate").Cells.Item(i).Specific).Value;
                        data.srokExpl = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("srokExpl").Cells.Item(i).Specific).Value;
                        data.snDate = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("snDate").Cells.Item(i).Specific).Value;
                        data.comment = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("comment").Cells.Item(i).Specific).Value;
                        data.warning = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("warning").Cells.Item(i).Specific).Value;
                        data.charact = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("charact").Cells.Item(i).Specific).Value;
                        data.modif = ((SAPbouiCOM.EditText)Matrix0.Columns.Item("modif").Cells.Item(i).Specific).Value;
                        data.docEntry = EditText7.Value;
                        data.lineId = (i - 1).ToString();

                        data.insID = EditText9.Value;

                        if (Button0.Caption == "Добавить")
                        {
                            AdoNetQueries.addData(data, 1);
                            Button0.Caption = "Обновить";
                            
                        }
                        if (Button0.Caption == "Обновить")
                        {
                            AdoNetQueries.updateData(data, 1);
                        }
                    }
                }
                else if (Folder1.Selected)
                {
                    for (var i = 1; i < (Matrix0.RowCount + 1); i++)
                    {
                        allFields data = new allFields();

                        data.code1 = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("code").Cells.Item(i).Specific).Value;
                        data.title = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("title").Cells.Item(i).Specific).Value;
                        data.batchNumber = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("batch").Cells.Item(i).Specific).Value;
                        data.articul = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("articul").Cells.Item(i).Specific).Value;
                        data.EAN = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("EAN").Cells.Item(i).Specific).Value;
                        data.createDate = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("create").Cells.Item(i).Specific).Value;
                        data.srokExpl = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("srokExpl").Cells.Item(i).Specific).Value;
                        data.shipingDate = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("ship").Cells.Item(i).Specific).Value;
                        data.comment = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("comment").Cells.Item(i).Specific).Value;
                        data.warning = ((SAPbouiCOM.EditText)Matrix1.Columns.Item("warning").Cells.Item(i).Specific).Value;
                        data.docEntry = EditText7.Value;
                        data.lineId = (i - 1).ToString();
                        data.insID = EditText9.Value;

                        if (Button0.Caption == "Добавить")
                        {
                            AdoNetQueries.addData(data, 2);
                            Button0.Caption = "Обновить";
                        }
                        if (Button0.Caption == "Обновить")
                        {
                            AdoNetQueries.updateData(data, 2);
                        }
                    }
                }
            } 
            else 
                if (Button0.Caption == "Ок")
                {
                    UIApp.Forms.ActiveForm.Close();
                }

            BubbleEvent = true;
        }

        private void Matrix1_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            if (pVal.ColUID == "code")
            {
                SAPbouiCOM.ISBOChooseFromListEventArg chflarg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                SAPbouiCOM.DataTable dt = chflarg.SelectedObjects;
                if (dt == null) { this.UIAPIRawForm.Freeze(false); return; }

                string ItemName = dt.GetValue("ItemName", 0).ToString();
                string ItemCode = dt.GetValue("ItemCode", 0).ToString();

                this.UIAPIRawForm.Items.Item("Item_33").Click(SAPbouiCOM.BoCellClickType.ct_Regular);
                Matrix1.Columns.Item("code").Editable = false;
                Matrix1.Columns.Item("title").Editable = false;

                (Matrix1.Columns.Item("code").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemCode;
                (Matrix1.Columns.Item("title").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemName;

                Matrix1.Columns.Item("code").Editable = true;
                Matrix1.Columns.Item("title").Editable = true;

                Matrix1.Columns.Item("batch").Editable = true;
                Matrix1.Columns.Item("batch").ChooseFromListUID = "CFL_BatchNumber";

                Matrix1.AddRow();
            }

            if (pVal.ColUID == "batch")
            {
                SAPbouiCOM.ISBOChooseFromListEventArg chflarg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                SAPbouiCOM.DataTable dt = chflarg.SelectedObjects;
                if (dt == null) { this.UIAPIRawForm.Freeze(false); return; }

                try
                {
                    var a = dt.GetValue("BatchNum", 0).ToString();
                    (Matrix1.Columns.Item("batch").Cells.Item(indexRow).Specific as SAPbouiCOM.EditText).Value = a;
                }
                catch
                {
                    (Matrix1.Columns.Item("batch").Cells.Item(indexRow).Specific as SAPbouiCOM.EditText).Value = dt.GetValue("BatchNum", 0).ToString();
                    UIApp.Forms.ActiveForm.Close();
                }

                indexRow = pVal.Row;
            }
        }

        private void Matrix0_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.ISBOChooseFromListEventArg chflarg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
            SAPbouiCOM.DataTable dt = chflarg.SelectedObjects;
            if (dt == null) { this.UIAPIRawForm.Freeze(false); return; }

            string ItemName = dt.GetValue("ItemName", 0).ToString();
            string ItemCode = dt.GetValue("ItemCode", 0).ToString();

            this.UIAPIRawForm.Items.Item("Item_33").Click(SAPbouiCOM.BoCellClickType.ct_Regular);
            Matrix0.Columns.Item("code").Editable = false;
            Matrix0.Columns.Item("title").Editable = false;
                
            (Matrix0.Columns.Item("code").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemCode;
            (Matrix0.Columns.Item("title").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemName;
            
            Matrix0.Columns.Item("code").Editable = true;
            Matrix0.Columns.Item("title").Editable = true;

            Matrix0.AddRow();
        }

        private void LinkedButton0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            string batchParam = (Matrix1.Columns.Item("batch").Cells.Item(indexRow).Specific as SAPbouiCOM.EditText).Value;
            var batch = AdoNetQueries.getAbsEntry(batchParam);
            if (batch != null)
            {
                this.UIApp.OpenForm((SAPbouiCOM.BoFormObjectEnum)10000044, null, batch);
            }
        }

        // Open Image
        private void Button3_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            var thread = new System.Threading.Thread(getPathToImage);
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
        }

        // Delete Image
        private void Button4_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            PictureBox0.Picture = "";
            (Matrix0.Columns.Item("photo").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value = "";
            Button4.Item.Visible = false;
            BubbleEvent = true;
        }

        public void getPathToImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
            //(this.UIAPIRawForm.Items.Item("photo").Specific as SAPbouiCOM.EditText).Value = "123";
            try
            {
                (Matrix0.Columns.Item("photo").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value = System.IO.Path.GetDirectoryName(openFileDialog1.FileName) + System.IO.Path.GetFileName(openFileDialog1.FileName);
                PictureBox0.Picture = System.IO.Path.GetDirectoryName(openFileDialog1.FileName) + System.IO.Path.GetFileName(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {

            }
        }

        
        private void Matrix1_ChooseFromListBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            
            if (pVal.ColUID == "batch")
            {
                indexRow = pVal.Row;
                columnRow = pVal.ColUID;
                string ItemCode = (Matrix1.Columns.Item("code").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value ;

                this.oForm = this.UIApp.Forms.Item(pVal.FormUID);

                this.CFL = this.oForm.ChooseFromLists.Item("CFL_BatchNumber");
                // Choose From List и фильтр по выбранному полю
                var coditions = this.UIApp.CreateObject(SAPbouiCOM.BoCreatableObjectType.cot_Conditions) as SAPbouiCOM.Conditions;

                // Условие "эквивалентно", также поддерживает поиск с "*"
                var condition = coditions.Add();
                condition.Alias = "ItemCode";
                condition.CondVal = ItemCode;
                condition.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                this.CFL.SetConditions(coditions);

                BubbleEvent = true;
            }
        }

        private void Matrix1_LinkPressedBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            if (pVal.ColUID == "batch")
            {
                string batchParam = (Matrix1.Columns.Item("batch").Cells.Item(indexRow).Specific as SAPbouiCOM.EditText).Value;
                var batch = AdoNetQueries.getAbsEntry(batchParam);
                if (batch != null)
                {
                    this.UIApp.OpenForm((SAPbouiCOM.BoFormObjectEnum)10000044, null, batch);
                }
            }

            if (pVal.ColUID == "code")
            {
                SAPbouiCOM.ISBOChooseFromListEventArg chflarg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;

                SAPbouiCOM.DataTable dt = chflarg.SelectedObjects;
                if (dt == null) { this.UIAPIRawForm.Freeze(false); }

                string ItemName = dt.GetValue("ItemName", 0).ToString();
                string ItemCode = dt.GetValue("ItemCode", 0).ToString();

                this.UIAPIRawForm.Items.Item("Item_33").Click(SAPbouiCOM.BoCellClickType.ct_Regular);
                Matrix1.Columns.Item("code").Editable = false;
                Matrix1.Columns.Item("title").Editable = false;

                (Matrix1.Columns.Item("code").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemCode;
                (Matrix1.Columns.Item("title").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemName;

                Matrix1.Columns.Item("code").Editable = true;
                Matrix1.Columns.Item("title").Editable = true;
                Matrix1.Columns.Item("batch").Editable = true;
                Matrix1.Columns.Item("batch").ChooseFromListUID = "CFL_BatchNumber";

                Matrix1.AddRow();
            }

            BubbleEvent = true;
        }

        public void OnInitializeFormEvents()
        {
        }

        private void Form_VisibleAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
           if(this.UIAPIRawForm.Visible)
           {
               this.UIAPIRawForm.Freeze(true);
               Folder0.Select();

               if ((dataForMatrixes[0].Length == 0) && (dataForMatrixes[1].Length == 0))
               {
                   Button0.Caption = "Добавить";
               }
               else
               {
                   Button0.Caption = "Ок";
                   for (var i = 0; i < dataForMatrixes[0].Length; i++)
                   {
                       
                       Matrix0.AddRow();
                       (Matrix0.Columns.Item("code").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].code1;
                       (Matrix0.Columns.Item("title").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].title;

                       (Matrix0.Columns.Item("photo").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].photo;
                       (Matrix0.Columns.Item("serialN").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].serialNumber;
                       (Matrix0.Columns.Item("articul").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].articul;
                       (Matrix0.Columns.Item("EAN").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].EAN;

                       (Matrix0.Columns.Item("instDate").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].instDate;
                       (Matrix0.Columns.Item("srokExpl").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].srokExpl;
                       (Matrix0.Columns.Item("snDate").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].snDate;
                       (Matrix0.Columns.Item("comment").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].comment;

                       (Matrix0.Columns.Item("warning").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].warning;
                       (Matrix0.Columns.Item("charact").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].charact;
                       (Matrix0.Columns.Item("modif").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].modif;
                   }

                   for (var i = 0; i < dataForMatrixes[1].Length; i++)
                   {
                       Matrix1.AddRow();
                       (Matrix1.Columns.Item("code").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].code1;
                       (Matrix1.Columns.Item("title").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].title;

                       (Matrix1.Columns.Item("batch").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].batchNumber;
                       (Matrix1.Columns.Item("articul").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].articul;
                       (Matrix1.Columns.Item("EAN").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].EAN;

                       (Matrix1.Columns.Item("create").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].createDate;
                       (Matrix1.Columns.Item("srokExpl").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].srokExpl;
                       (Matrix1.Columns.Item("ship").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].shipingDate;

                       (Matrix1.Columns.Item("comment").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].comment;
                       (Matrix1.Columns.Item("warning").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].warning;
                   }
               }

               Matrix0.AddRow();
               Matrix1.AddRow();

               if ((Matrix0.Columns.Item("photo").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value == "" || (Matrix0.Columns.Item("photo").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value == null)
               {
                   Button4.Item.Visible = false;
               }
               else
               {
                   Button4.Item.Visible = true;
               }
               this.UIAPIRawForm.Freeze(false);
           }
           //Form1.allFields data = new allFields();
           //AdoNetQueries.updateData(data, 1);
        }


        public void draw()
        {
            int redBackColor = System.Drawing.Color.Red.R | (System.Drawing.Color.Red.G << 8) | (System.Drawing.Color.Red.B << 16);
            int greenBackColor = System.Drawing.Color.Green.R | (System.Drawing.Color.Green.G << 8) | (System.Drawing.Color.Green.B << 16);
            int yellowBackColor = System.Drawing.Color.Yellow.R | (System.Drawing.Color.Yellow.G << 8) | (System.Drawing.Color.Yellow.B << 16);

            for (var i = 1; i < Matrix0.RowCount + 1; i++)
            {
                //instDate
                //drDownDate
                string instDate = (Matrix0.Columns.Item("instDate").Cells.Item(i).Specific as SAPbouiCOM.EditText).Value;
                DateTime instDate2 = new DateTime(Convert.ToInt32(instDate.Substring(0, 4)), Convert.ToInt32(instDate.Substring(4, 2)), Convert.ToInt32(instDate.Substring(6, 2)));

                string drDownDate = (Matrix0.Columns.Item("drDownDate").Cells.Item(i).Specific as SAPbouiCOM.EditText).Value;
                DateTime drDownDate2 = new DateTime(Convert.ToInt32(drDownDate.Substring(0, 4)), Convert.ToInt32(drDownDate.Substring(4, 2)), Convert.ToInt32(drDownDate.Substring(6, 2)));

                int srokExpl = Convert.ToInt32((Matrix0.Columns.Item("srokExpl").Cells.Item(i).Specific as SAPbouiCOM.EditText).Value);

                //instDate2 = instDate2.AddDays();

                this.Matrix0.CommonSetting.SetRowBackColor(i, greenBackColor);

                instDate2 = instDate2.AddDays(srokExpl);
                if (instDate2 < drDownDate2)
                {

                }

                /*
                if ( date2 != null )
                {
                    this.Matrix0.CommonSetting.SetRowBackColor(i, greenBackColor);
                }
                */
            }

            for (var i = 1; i < Matrix1.RowCount; i++)
            {
                //instDate2 = instDate2.AddDays();

                this.Matrix1.CommonSetting.SetRowBackColor(i, greenBackColor);
            }
        }

        private void Matrix0_ValidateAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            

        }
    }
}