using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
  {
    public string Name { get; set; }
    public int Id { get; }
    public List<Item> Items { get; set; }
    private static List<Category> _instances = new List<Category> {};

    public Category(string categoryName)
    {
      Name = categoryName;
      _instances.Add(this);
      Id = _instances.Count;
      Items = new List<Item>{};
    }

  public static void ClearAll()
  {
    _instances.Clear();
  }
  }
}