using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 2, 0);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -2, 0);
            //transform.rotation = new Quaternion(0.1f, 0, 0, 1);

        }
    }
}
