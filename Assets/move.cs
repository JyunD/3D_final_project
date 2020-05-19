using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float Speed = 10;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 2, 0);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -2, 0);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }

        if (Input.GetKey(KeyCode.V))
        {
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }


    }
}
