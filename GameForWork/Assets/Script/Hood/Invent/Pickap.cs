using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickap : MonoBehaviour
{
    public GameObject ItemButton;
    private Inventory inventory;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            for(int i = 0; i < inventory.slots.Length; i++)
            {
                if(!inventory.Full[i])
                {
                    inventory.Full[i] = true;
                    Instantiate(ItemButton, inventory.slots[i]. transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
