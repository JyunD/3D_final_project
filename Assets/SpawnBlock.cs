using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    private float Timer = 0;
    public Object[] Bs;
    public GameObject B;
    public static bool _spawn = false;
    private int r;
    // Start is called before the first frame update
    void Start()
    {
        Bs = Resources.LoadAll("", typeof(GameObject));
    }

    // Update is called once per frame
    void Update()
    {
        if (_spawn == false && Timer > 1) {
            r = Random.Range(0, Bs.Length);
            B = Instantiate(Bs[r] as GameObject, new Vector3(0, 7, 0), Quaternion.identity);
            _spawn = true;
            Timer = 0;
            
        }
        else
            Timer += Time.deltaTime;

        B.transform.Translate(Vector3.down * Time.deltaTime * 2);
        if (Input.GetKey(KeyCode.W))
        {
            B.transform.Translate(Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            B.transform.Translate(Vector3.back * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            B.transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            B.transform.Translate(Vector3.right * 0.1f);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            B.transform.Rotate(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            B.transform.Rotate(0, 5, 0);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.tag = "Untagged";
            _spawn = false;
        }
    }
}
