using UnityEngine;
using System.Collections.Generic;

//Testing to see if I can buy and sell from shop
//sometimes works, sometimes doesnt work
public class Shop : MonoBehaviour
{
    public List<Item> stock;
    public Inventory inventory;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Buy(0);
    }

    public void AddToStock(Item item)
    {
        stock.Add(item);
    }

    void Buy(int i)
    {
        inventory.AddToInvetory(stock[i]);
        stock[i] = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
