using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float moveSpeed;
    public float rotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.W))
        {
            // move along z axis
            //transform.Translate(Vector3.forward * Time.deltaTime);
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            // move along z axis
            //transform.Translate(Vector3.back * Time.deltaTime);
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            // move along z axis
            //transform.Translate(Vector3.left * Time.deltaTime);
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            // move along z axis
            //transform.Translate(Vector3.right * Time.deltaTime);
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            // move along z axis
            //transform.Translate(Vector3.up * Time.deltaTime);
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        /*if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, Time.deltaTime * rotSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, Time.deltaTime * rotSpeed);
        }*/


    }
}
