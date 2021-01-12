using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    Vector3 velocity;
    Vector3 position;
    public Transform target;
    float period=1f;
    bool push=false;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            push = true;
        }
        if(push == true)
        {
            var acceleration = Vector3.zero;

            var diff = (target.position - position);
            acceleration += (diff - velocity * period) * 2f / (period * period);

            period -= Time.deltaTime;
            if (period < 0f)
            {
                return;
            }

            velocity += acceleration * Time.deltaTime;
            position += velocity * Time.deltaTime;
            transform.position = position;
        }
        
    }
}
