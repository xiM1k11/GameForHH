using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slot : MonoBehaviour
{
    private Inventory inventory;
    public int NumberSlot;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.childCount <= 0)
        {
            inventory.Full[NumberSlot] = false;
        }
    }

    public void DropItem()
    {
       foreach (Transform child in transform)
       {
        child.GetComponent<Spawns>().DropItem();
       }
    }
}
