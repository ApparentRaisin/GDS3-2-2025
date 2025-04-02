using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    List<Item> itemsInInventory;
    public Shop shop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SellToShop(0);
    }

    public void AddToInvetory(Item item)
    {
        itemsInInventory.Add(item);
    }

    public void SellToShop(int i)
    {
        shop.AddToStock(itemsInInventory[i]);
        itemsInInventory[i] = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
