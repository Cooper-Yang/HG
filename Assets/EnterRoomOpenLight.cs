using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoomOpenLight : MonoBehaviour
{
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
        if (gameObject.GetComponent<BoxCollider2D>().IsTouchingLayers(player))
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        
    }
}
