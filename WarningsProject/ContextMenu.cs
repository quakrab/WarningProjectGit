using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarningsProject
{
    class ContextMenu
    {
        private static ContextMenu obj;
        public static ContextMenu GetObj
        {
            get
            {
                if (obj == null) obj = new ContextMenu();
                return obj;
            }
        }

        private Menus menu;
        private List<MenuCreationParams> subMenu;

        private Application CurApplication
        {
            get { return SAPbouiCOM.Framework.Application.SBO_Application; }
        }
        private ContextMenu()
        {
            menu = SAPbouiCOM.Framework.Application.SBO_Application.Menus.Item("1280").SubMenus;
            subMenu = new List<MenuCreationParams>();
        }

        public void CreateMenu(params string[] subMenuParam)
        {
            Clear();
            int id = 0;
            foreach (var itemMenu in subMenuParam)
            {
                var m = CurApplication.CreateObject(BoCreatableObjectType.cot_MenuCreationParams) as MenuCreationParams;
                m.Type = BoMenuType.mt_STRING;
                m.Position = id;
                m.UniqueID = "subMenu" + (id++).ToString();
                m.String = itemMenu;
                m.Enabled = true;
                subMenu.Add(m);
                if (!menu.Exists(m.UniqueID)) menu.AddEx(m);
            }
        }
        public void Clear()
        {
            foreach (var m in subMenu)
            {
                if (menu.Exists(m.UniqueID)) menu.RemoveEx(m.UniqueID);
            }
            subMenu.Clear();
        }
    }
}
