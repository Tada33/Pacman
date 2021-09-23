using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonMove : MonoBehaviour
{
    float move = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += move;
        if(pos.x < -3.5f)
        {
            move = 0.08f;
        }

       
        if (pos.x < -3.5f)
        {
            move = 0.08f;
        }

        transform.position = pos;
    }
}
