using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;

namespace WarningsProject
{
    [FormAttribute("UDO_FT_warning_udo")]
    class UDOForm2 : UserFormBase
    {
        private SAPbouiCOM.Application UIApp = SAPbouiCOM.Framework.Application.SBO_Application;
        //private SAPbouiCOM.Form oForm;
        public string sn = "sn";
        public string bpName = "bpName";
        public string itemName = "itemName";

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.LinkedButton LinkedButton0;
        private SAPbouiCOM.LinkedButton LinkedButton1;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.EditText EditText3;

        public UDOForm2()
        {
            UIApp.ItemEvent += UIApp_ItemEvent;

            //var f = new UDOForm2(sn, bpName, itemName);
        }

        public UDOForm2(string sn, string bpName, string itemName)
        {
            this.sn = sn;
            this.bpName = bpName;
            this.itemName = itemName;
        }

        void UIApp_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("1_U_G").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.LinkedButton0 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_6").Specific));
            this.LinkedButton1 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_7").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_10").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_12").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_13").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Matrix Matrix0;

        private void OnCustomInitialize()
        {
            EditText2.Value = sn;
            EditText0.Value = bpName;
            EditText1.Value = itemName;

            //Draw in matrix
            //Int32 Row = 1;
            SAPbouiCOM.Matrix oMatrix = (SAPbouiCOM.Matrix)UIApp.Forms.ActiveForm.Items.Item("0_U_G").Specific;

            int redBackColor = System.Drawing.Color.Red.R | (System.Drawing.Color.Red.G << 8) | (System.Drawing.Color.Red.B << 16);
            int greenBackColor = System.Drawing.Color.Green.R | (System.Drawing.Color.Green.G << 8) | (System.Drawing.Color.Green.B << 16);
            int yellowBackColor = System.Drawing.Color.Yellow.R | (System.Drawing.Color.Yellow.G << 8) | (System.Drawing.Color.Yellow.B << 16);

            //Set cell background
            oMatrix.CommonSetting.SetCellBackColor(1, 1, yellowBackColor);
            //Set row background

            //oMatrix.CommonSetting.SetRowBackColor(1, 135);
            //Form updating
            UIApp.Forms.ActiveForm.Update();
        }
    }
}


/*
namespace WarningsProject
{
    [FormAttribute("UDO_FT_warning_udo")]
    class UDOForm2 : UserFormBase
    {
        private SAPbouiCOM.Application UIApp = SAPbouiCOM.Framework.Application.SBO_Application;
        //private SAPbouiCOM.Form oForm;
        public string sn = "sn";
        public string bpName = "bpName";
        public string itemName = "itemName";

        public UDOForm2()
        {
            UIApp.ItemEvent += UIApp_ItemEvent;

            //var f = new UDOForm2(sn, bpName, itemName);
        }

        public UDOForm2(string sn, string bpName, string itemName)
        {
            this.sn = sn;
            this.bpName = bpName;
            this.itemName = itemName;
        }

        void UIApp_ItemEvent(string FormUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            //SAPbouiCOM.EditText sn = (SAPbouiCOM.EditText)UIApp.Forms.Item("60150").Items.Item("44").Specific;

            BubbleEvent = true;
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("1_U_G").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_3").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.LinkedButton0 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_6").Specific));
            this.LinkedButton1 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_7").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_10").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_11").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_12").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_13").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private SAPbouiCOM.Matrix Matrix0;

        private void OnCustomInitialize()
        {
            EditText2.Value = sn;
            EditText0.Value = bpName;
            EditText1.Value = itemName;

            //Draw in matrix
            //Int32 Row = 1;
            SAPbouiCOM.Matrix oMatrix = (SAPbouiCOM.Matrix)UIApp.Forms.ActiveForm.Items.Item("0_U_G").Specific;

            int redBackColor = System.Drawing.Color.Red.R | (System.Drawing.Color.Red.G << 8) | (System.Drawing.Color.Red.B << 16);
            int greenBackColor = System.Drawing.Color.Green.R | (System.Drawing.Color.Green.G << 8) | (System.Drawing.Color.Green.B << 16);
            int yellowBackColor = System.Drawing.Color.Yellow.R | (System.Drawing.Color.Yellow.G << 8) | (System.Drawing.Color.Yellow.B << 16);

            //Set cell background
            oMatrix.CommonSetting.SetCellBackColor(1, 1, yellowBackColor);
            //Set row background
            
            //oMatrix.CommonSetting.SetRowBackColor(1, 135);
            //Form updating
            UIApp.Forms.ActiveForm.Update();
        }

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.LinkedButton LinkedButton0;
        private SAPbouiCOM.LinkedButton LinkedButton1;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.EditText EditText3;
    }
}

/*
            Draw in matrix
    //Int32 Row = 1;
    SAPbouiCOM.Matrix oMatrix = (SAPbouiCOM.Matrix)UIApp.Forms.ActiveForm.Items.Item("0_U_G").Specific;
    //Set cell background
    oMatrix.CommonSetting.SetCellBackColor(1, 1, 135);
    //Set row background
    oMatrix.CommonSetting.SetRowBackColor(1, 135);
    //Form updating
    UIApp.Forms.ActiveForm.Update();
*/