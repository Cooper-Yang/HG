using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoomOpenLight : MonoBehaviour
{
    public Collider2D player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (GetComponent<BoxCollider2D>().IsTouching(player))
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        
    }
}
