using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaviour : MonoBehaviour
{
    private float Timer = 0;
    private AudioSource bruh;
    public Rigidbody rigidbody;
    public bool _isCollision = false, _collisionmap = false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        bruh = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer >= 1) {
            SpawnBlock.end = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (_isCollision == false)
        {
            if (collision.gameObject.tag.Equals("Untagged"))
            {
                rigidbody.useGravity = true;
                _isCollision = true;
                gameObject.tag = "Untagged";
                SpawnBlock._spawn = false;
            }
            if (collision.gameObject.tag.Equals("Map"))
            {
                rigidbody.useGravity = true;
                _isCollision = true;
                _collisionmap = true;
                gameObject.tag = "Untagged";
                SpawnBlock._spawn = false;
                bruh.Play();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "cardia" && _isCollision==true)
        {
            Timer += Time.deltaTime;

        }
    }
}
