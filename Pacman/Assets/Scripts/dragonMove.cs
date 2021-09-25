using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonMove : MonoBehaviour
{
    float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Translate(0, 0, 0);
    }
   
   
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(5, 0, 0/ 50);
        this.transform.Translate(5, -4, 0);
        this.transform.Translate(0, -4, 0);
        this.transform.Translate(0, 0, 0);
    }
    
}
