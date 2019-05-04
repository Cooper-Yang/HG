using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject monster;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FieldOfView.on)
        {
            transform.position = player.transform.position;
        }

        if (!FieldOfView.on)
        {
            transform.position = monster.transform.position;
        }
    }
}
