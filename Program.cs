using System.IO;
using System.Collections.Generic;
public enum Menuitems{name,description,ingredients,mealnumber,price}
   public class menuitems 

    


        public string name { get; set; }

        public string description { get; set; }

        public string ingredients{ get; set; }

        public int mealnumber { get; set; }

        public int price{ get; set; }

      

    
public  Menuitems(){


}
public Menuitems(string name,string Discription,string Ingredients, int Mealnumber,int Price)
{
    name= Mealname;
    description=Discription;
    ingredients=Ingredients;
    mealnumber = Mealnumber;
    price=Price; 
}

   public bool AddMenuitemsToDirectory(Menuitems menu)
    {
        int startingCount = _menuDirectory.Count;
        _menuDirectory.Add(menu);
        bool wasAdded = _menuDirectory.Count > startingCount;
        return wasAdded;
    }
   private void Seed()
    {
        Menuitems itemsOne = new Menuitems(
            "Smothered chicken",
            "is made with juicy fried chicken breast",
            "Grilled chicken breast topped with mushroom,onion,and cheese",
            5,
            7
        );
        Menuitems itemsTwo = new Menuitems(
            "Grilled Fingerlings",
            "Grilled potato is a healthy way to enjoy this strachy vegetable",
            "Grilled potatoes with a wastern flkair served with sauce of choice",
            4,
            6
        
        );
        
        AddMenuitemsToDirectory(itemsOne);
        AddMenuitemsToDirectory(itemsTwo);

    }

    // using System.Collections.Generic;

public class menuitems
{
    private readonly List<Menuitems> _menuDirectory = new List<Menuitems>();

    public menuitems()
    {
        Seed();
    }
    public bool AddMenuitemsToDirectory(Menuitems menu)
    {
        int startingCount = _menuDirectory.Count;
        _menuDirectory.Add(menu);
        bool wasAdded = _menuDirectory.Count > startingCount;
        return wasAdded;
    }

     public List<Menuitems> GetAllMenuItems()
    {
        return _menuDirectory;
    }

    public Menuitems GetmenuByName(string name)
    {
        foreach (Menuitems menu in _menuDirectory)
        {
            if (menu.name.ToLower() == name.ToLower())
            {
                return menu;
            }
        }
        return default;
    }
        public bool UpdateExistingmenu(string originalName, Menuitems newMenu)
    {
        Menuitems oldMenu = GetmenuByName(originalName);

        if (oldMenu != default)
        {
            oldMenu.name = newMenu.name;
            oldMenu.description = newMenu.description;
            oldMenu.ingredients = newMenu.ingredients;
            oldMenu.mealnumber = newMenu.mealnumber;
            oldMenu.price = newMenu.price;

            return true;
        }
        else
        {
            return false;
        }
    }
        public bool DeleteExistingmenu(string title)
    {
        Menuitems menuToDelete = GetmenuByName(title);

        if(menuToDelete != default)
        {
            bool deleteResult = _menuDirectory.Remove(menuToDelete);
            return deleteResult;
        }
        else
        {

            return false;
        }
        
}
}     
  