namespace NavigationMenu
{
    public class Menu
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public int? ParentID { get; set; }
        public bool IsHidden { get; set; }
        public string LinkURL { get; set; }


    }
}
