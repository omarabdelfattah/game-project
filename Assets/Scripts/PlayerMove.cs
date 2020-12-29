using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float Hinput, Vinput;
    float boundary_left     = -12.45f;
    float boundary_right    = 12.45f;
    float boundary_up       = 2f;
    float boundary_down      = -6.71f;
    float  speed             = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            Hinput = Input.GetAxis("Horizontal");
            Vinput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * Hinput * Time.deltaTime * speed);
            transform.Translate(Vector3.forward * Vinput * Time.deltaTime * speed);

        if(transform.position.x < boundary_left)
        {
            transform.position = new Vector3(boundary_left, transform.position.y, transform.position.z);
        }
        if (transform.position.x > boundary_right)
        {
            transform.position = new Vector3(boundary_right, transform.position.y, transform.position.z);
        }
        if (transform.position.y > boundary_up)
        {
            transform.position = new Vector3(transform.position.x, boundary_up, transform.position.z);
        }
        if (transform.position.y < boundary_down)
        {
            transform.position = new Vector3(transform.position.x, boundary_down, transform.position.z);
        }

    }
}
