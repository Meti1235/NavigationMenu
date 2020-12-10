using System;
using System.Collections.Generic;

namespace NavigationMenu
{
    public class MyCSVParser
    {
        public List<Menu> DeserializeCSV(string csv)
        {
            List<Menu> menuList = new List<Menu>();

            string[] content = csv.Trim().Split(Environment.NewLine);
            for (int i = 1; i < content.Length; i++)
            {
                Menu menu = new Menu();

                string[] propertyNames = content[0].Split(';');
                string[] propertyValues = content[i].Split(';');

                Dictionary<string, string> menuDictionary = new Dictionary<string, string>();
                for (int j = 0; j < propertyNames.Length; j++)
                {
                    menuDictionary.Add(propertyNames[j].Trim(), propertyValues[j].Trim());
                }

                menu.ID = int.Parse(menuDictionary["ID"]);
                menu.MenuName = menuDictionary["MenuName"];
                menu.ParentID = menuDictionary["ParentID"].ToNullableInt();
                menu.IsHidden = bool.Parse(menuDictionary["isHidden"]);
                menu.LinkURL = menuDictionary["LinkURL"];

                menuList.Add(menu);
            }

            return menuList;
        }
    }
}
