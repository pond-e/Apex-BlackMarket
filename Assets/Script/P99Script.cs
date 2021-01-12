using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P99Script : MonoBehaviour
{
    private float _gravity  = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y > 0.26f)
        {
            this.transform.position -= new Vector3(0,_gravity,0);
        }
    }
}
