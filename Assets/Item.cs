using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Item
{
    public string name;
    public string description;
    public UnityEvent onUse = new UnityEvent();

    public void Use()
    {
        onUse.Invoke();
    }
}

[System.Serializable]
public class Weapon : Item
{
    public int damage;
}
