using System;
using System.Collections.Generic;

namespace NavigationMenu
{
    public static class ValidateHelper
    {
        public static int? ToNullableInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }
        //public static void RecursivePrint(this List<Menu> myMenuList)
        //{
        //    if (myMenuList != null)
        //    {
        //        foreach (var parent in myMenuList)
        //        {
        //            foreach (Menu child in myMenuList)
        //            {
        //                if (child.ParentID == parent.ID && child.IsHidden == false)
        //                {
        //                    Console.Write("* ");
        //                    Console.WriteLine(child.MenuName);
        //                    myMenuList.Remove(child);
        //                    if (myMenuList != null)
        //                    {
        //                        RecursivePrint(myMenuList);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        public static void PrintMenu(this List<Menu> myMenuList)
        {
            for (int i = 0; i < myMenuList.Count; i++)
            {
                if (myMenuList[i].ParentID == null && myMenuList[i].IsHidden == false)
                {
                    Console.Write("* ");
                    Console.WriteLine(myMenuList[i].MenuName);

                    foreach (var child in myMenuList)
                    {
                        if (child.ParentID == myMenuList[i].ID && child.IsHidden == false)
                        {
                            Console.Write("* * * * ");
                            Console.WriteLine(child.MenuName);

                            foreach (var grandChild in myMenuList)
                            {
                                if (grandChild.ParentID == child.ID && grandChild.IsHidden == false)
                                {
                                    Console.Write("* * * * * * * ");
                                    Console.WriteLine(grandChild.MenuName);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}