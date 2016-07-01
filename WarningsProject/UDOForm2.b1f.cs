using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using System.Windows.Forms;



namespace WarningsProject
{
    [FormAttribute("UDO_FT_warning_udo")]
    class UDOForm2 : UDOFormBase
    {
        private SAPbouiCOM.Application UIApp = SAPbouiCOM.Framework.Application.SBO_Application;
        //private SAPbouiCOM.Form oForm;
        
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.EditText EditText3;

        public SAPbouiCOM.ChooseFromList CFL { get; set; }
        public SAPbouiCOM.Button B_ChoosefromList { get; set; }
        public string columnRow { get; set; }

        private SAPbouiCOM.Form oForm;

        WarningsProject.Form1.allFields[][] dataForMatrixes = new WarningsProject.Form1.allFields[2][];

        int indexRow = 1;

        public UDOForm2()
        {
            UIApp.ItemEvent += UIApp_ItemEvent;
            UIApp.MenuEvent += UIApp_MenuEvent;
        }

        void UIApp_MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            if (pVal.MenuUID == "1281")
            {

            }
            //throw new NotImplementedException();
        }

        void UIApp_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            //47620
            /*
            if (pVal.FormType == 65053)
            {
                if ((Matrix0.Columns.Item("photo").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value == "" || (Matrix0.Columns.Item("photo").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value == null)
                {
                    Button1.Item.Visible = false;
                }
                else
                {
                    Button1.Item.Visible = true;
                }
            }
            */
            if (!pVal.BeforeAction)
            {

            }
            BubbleEvent = true;
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_10").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_12").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_13").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.LinkedButton0 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_6").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_7").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_9").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_14").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_15").Specific));
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_18").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_19").Specific));
            this.LinkedButton1 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_20").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_21").Specific));
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("Item_22").Specific));
            this.PictureBox0 = ((SAPbouiCOM.PictureBox)(this.GetItem("Item_23").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_24").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_25").Specific));
            this.Button1.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button1_ClickBefore);
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("0_U_G").Specific));
            this.Matrix0.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.Matrix0_ChooseFromListAfter);
            this.Matrix1 = ((SAPbouiCOM.Matrix)(this.GetItem("1_U_G").Specific));
            this.Matrix1.LinkPressedBefore += new SAPbouiCOM._IMatrixEvents_LinkPressedBeforeEventHandler(this.Matrix1_LinkPressedBefore);
            this.Matrix1.ChooseFromListBefore += new SAPbouiCOM._IMatrixEvents_ChooseFromListBeforeEventHandler(this.Matrix1_ChooseFromListBefore);
            this.Matrix1.ChooseFromListAfter += new SAPbouiCOM._IMatrixEvents_ChooseFromListAfterEventHandler(this.Matrix1_ChooseFromListAfter);
            this.OnCustomInitialize();
        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            this.VisibleAfter += new VisibleAfterHandler(this.Form_VisibleAfter);
        }

        private void OnCustomInitialize()
        {
            
        }

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.LinkedButton LinkedButton0;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.StaticText StaticText9;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.LinkedButton LinkedButton1;
        private SAPbouiCOM.StaticText StaticText10;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.PictureBox PictureBox0;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.Button Button1;

        private void Button0_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            var thread = new System.Threading.Thread(getPathToImage);
            thread.SetApartmentState(System.Threading.ApartmentState.STA);
            thread.Start();
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

        private void Button1_ClickBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            PictureBox0.Picture = "";
            (Matrix0.Columns.Item("photo").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value = "";
            Button1.Item.Visible = false;
            BubbleEvent = true;
        }

        private SAPbouiCOM.Matrix Matrix0;
        private SAPbouiCOM.Matrix Matrix1;

        private void Matrix1_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            if (pVal.ColUID == "code")
            {
                SAPbouiCOM.ISBOChooseFromListEventArg chflarg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
                SAPbouiCOM.DataTable dt = chflarg.SelectedObjects;
                if (dt == null) { this.UIAPIRawForm.Freeze(false); return; }

                string ItemName = dt.GetValue("ItemName", 0).ToString();
                string ItemCode = dt.GetValue("ItemCode", 0).ToString();

                this.UIAPIRawForm.Items.Item("Item_23").Click(SAPbouiCOM.BoCellClickType.ct_Regular);
                Matrix1.Columns.Item("code").Editable = false;
                Matrix1.Columns.Item("title").Editable = false;

                (Matrix1.Columns.Item("code").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemCode;
                (Matrix1.Columns.Item("title").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemName;

                Matrix1.Columns.Item("code").Editable = true;
                Matrix1.Columns.Item("title").Editable = true;

                Matrix1.Columns.Item("batch").Editable = true;
                Matrix1.Columns.Item("batch").ChooseFromListUID = "CFL_BatchNumber";

                Matrix1.AddRow();
                (Matrix1.Columns.Item("insID").Cells.Item(pVal.Row + 1).Specific as SAPbouiCOM.EditText).Value = EditText7.Value;
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

        private void Matrix1_ChooseFromListBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            if (pVal.ColUID == "batch")
            {
                indexRow = pVal.Row;
                columnRow = pVal.ColUID;
                string ItemCode = (Matrix1.Columns.Item("code").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value;

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

        private void Matrix0_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.ISBOChooseFromListEventArg chflarg = (SAPbouiCOM.ISBOChooseFromListEventArg)pVal;
            SAPbouiCOM.DataTable dt = chflarg.SelectedObjects;
            if (dt == null) { this.UIAPIRawForm.Freeze(false); return; }

            string ItemName = dt.GetValue("ItemName", 0).ToString();
            string ItemCode = dt.GetValue("ItemCode", 0).ToString();

            this.UIAPIRawForm.Items.Item("Item_23").Click(SAPbouiCOM.BoCellClickType.ct_Regular);
            Matrix0.Columns.Item("code").Editable = false;
            Matrix0.Columns.Item("title").Editable = false;

            (Matrix0.Columns.Item("code").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemCode;
            (Matrix0.Columns.Item("title").Cells.Item(pVal.Row).Specific as SAPbouiCOM.EditText).Value = ItemName;

            Matrix0.Columns.Item("code").Editable = true;
            Matrix0.Columns.Item("title").Editable = true;

            //Matrix0.AddRow();
            (Matrix0.Columns.Item("insID").Cells.Item(pVal.Row + 1).Specific as SAPbouiCOM.EditText).Value = EditText7.Value;
        }
        
        private void Form_VisibleAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
            if(this.UIAPIRawForm.Visible)
            {
                if ( WarningsProject.Menu.initData != null )
                {
                    EditText4.Value = WarningsProject.Menu.initData.createDate.Substring(0, WarningsProject.Menu.initData.createDate.LastIndexOf(" ")); // Create date
                    EditText5.Value = WarningsProject.Menu.initData.customer;   // CodeBP
                    EditText0.Value = WarningsProject.Menu.initData.custmrName; // BP Name
                    EditText6.Value = WarningsProject.Menu.initData.itemCode;   // Item Code

                    EditText1.Value = WarningsProject.Menu.initData.itemName;   // Item Name
                    EditText2.Value = WarningsProject.Menu.initData.internalSN; // Serial Number
                    EditText7.Value = WarningsProject.Menu.initData.insID;      // Ins ID

                    dataForMatrixes = AdoNetQueries.whereFormIsOpenMatrix0(WarningsProject.Menu.initData.insID);

                    this.UIAPIRawForm.Freeze(true);

                    if (dataForMatrixes[0].Length == 0)
                    {
                        (Matrix0.Columns.Item("insID").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value = EditText7.Value;
                    }
                    if (dataForMatrixes[1].Length == 0)
                    {
                        (Matrix1.Columns.Item("insID").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value = EditText7.Value;
                    }


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
                        (Matrix0.Columns.Item("insID").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].insID;

                        if (dataForMatrixes[0][i].track == "1")
                        {
                            (Matrix0.Columns.Item("track").Cells.Item(i + 1).Specific as SAPbouiCOM.CheckBox).Checked = false;
                        }
                        else
                            if (dataForMatrixes[0][i].track == "0")
                            {
                                (Matrix0.Columns.Item("track").Cells.Item(i + 1).Specific as SAPbouiCOM.CheckBox).Checked = true;
                            }
                        //(Matrix0.Columns.Item("track").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[0][i].track;

                    }

                    for (var i = 0; i < dataForMatrixes[1].Length; i++)
                    {
                        Matrix1.AddRow();
                        (Matrix1.Columns.Item("code").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].code1;
                        (Matrix1.Columns.Item("title").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].title;

                        (Matrix1.Columns.Item("batch").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].batchNumber;
                        (Matrix1.Columns.Item("articul").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].articul;
                        (Matrix1.Columns.Item("EAN").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].EAN;

                        (Matrix1.Columns.Item("create").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].createDate;
                        (Matrix1.Columns.Item("srokExpl").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].srokExpl;
                        (Matrix1.Columns.Item("ship").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].shipingDate;

                        (Matrix1.Columns.Item("comment").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].comment;
                        (Matrix1.Columns.Item("warning").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].warning;
                        (Matrix1.Columns.Item("insID").Cells.Item(i + 1).Specific as SAPbouiCOM.EditText).Value = dataForMatrixes[1][i].insID;

                        if (dataForMatrixes[1][i].track == "1")
                        {
                            (Matrix1.Columns.Item("track").Cells.Item(i + 1).Specific as SAPbouiCOM.CheckBox).Checked = false;
                        }
                        else
                            if (dataForMatrixes[1][i].track == "0")
                            {
                                (Matrix1.Columns.Item("track").Cells.Item(i + 1).Specific as SAPbouiCOM.CheckBox).Checked = true;
                            }
                    }
                }
                if ((Matrix0.Columns.Item("photo").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value == "" || (Matrix0.Columns.Item("photo").Cells.Item(1).Specific as SAPbouiCOM.EditText).Value == null)
                {
                    Button1.Item.Visible = false;
                }
                else
                {
                    Button1.Item.Visible = true;
                }

                this.UIAPIRawForm.Freeze(false);
            }
        }
    }
}