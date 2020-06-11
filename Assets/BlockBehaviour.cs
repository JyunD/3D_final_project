using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    private float Timer = 0;
    public Rigidbody rigidbody;
    public bool _isCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (!_isCollision)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 2);
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * 0.1f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * 0.1f);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * 0.1f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * 0.1f);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(0, -5, 0);
            }
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(0, 5, 0);
            }
        }*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            rigidbody.useGravity = true;
            _isCollision = true;
            collision.gameObject.tag = "Untagged";
            SpawnBlock._spawn = false;
        }
        if (collision.gameObject.tag.Equals("Untagged"))
        {
            rigidbody.useGravity = true;
            _isCollision = true;
            collision.gameObject.tag = "Untagged";
            SpawnBlock._spawn = false;
        }
    }
}
