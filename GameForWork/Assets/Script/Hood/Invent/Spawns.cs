using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawns : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    public void DropItem()
    {
        Vector2 playerPos = new Vector2(player.position.x - 1, player.position.y);
        Instantiate(item, playerPos, Quaternion.identity);
        Destroy(gameObject);
    }
}
