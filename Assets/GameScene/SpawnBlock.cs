using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnBlock : MonoBehaviour
{
    private float Timer = 0;
    public Object[] Bs;
    public GameObject B;
    public static bool _spawn = false, end = false;
    public PlayerManager pm;
    public static int spawn_num = 0;
    public AudioSource _rotate_sound;
    private int r;
    private int c;
    float speed;
    public Button _binge;
    private float ext = 1;

    // Start is called before the first frame update
    void Start()
    {
        Bs = Resources.LoadAll("", typeof(GameObject));
        pm = FindObjectOfType<PlayerManager>();
        spawn_num = 0;
        c = 0;
        speed = pm.block_speed;
        _binge.onClick.AddListener(Binge);


    }

    // Update is called once per frame
    void Update()
    {
        
        if (c == 15)
        {
            c = 0;
        }
        if (c > 0)
        {
            c += 1;
        }


        if (_spawn == false && Timer > 1 && end == false) {
            r = Random.Range(0, Bs.Length);
            B = Instantiate(Bs[r] as GameObject, new Vector3(-1, 14, 0), Quaternion.identity);
            B.transform.localScale = new Vector3(pm.block_size, pm.block_size, pm.block_size);
            _spawn = true;
            Timer = 0;
            spawn_num += 1;
        }
        else
            Timer += Time.deltaTime * ext;

        if (end == false)
        {
            //B.transform.Translate(Vector3.down * Time.deltaTime * 2 * pm.block_speed);
            B.transform.position = new Vector3(B.transform.position.x, B.transform.position.y - Time.deltaTime * 2 * speed, B.transform.position.z);

            if (Input.GetKey(KeyCode.W))
            {
                B.transform.position = new Vector3(B.transform.position.x , B.transform.position.y, B.transform.position.z + 0.1f);
            }
            if (Input.GetKey(KeyCode.S))
            {
                B.transform.position = new Vector3(B.transform.position.x, B.transform.position.y, B.transform.position.z - 0.1f);

            }
            if (Input.GetKey(KeyCode.A))
            {
                B.transform.position = new Vector3(B.transform.position.x - 0.1f, B.transform.position.y, B.transform.position.z );

            }
            if (Input.GetKey(KeyCode.D))
            {
                B.transform.position = new Vector3(B.transform.position.x + 0.1f, B.transform.position.y, B.transform.position.z);

            }
            if (Input.GetKey(KeyCode.Space))
            {
                B.transform.position = new Vector3(B.transform.position.x, B.transform.position.y - 0.1f, B.transform.position.z);
            }
            if (Input.GetKey(KeyCode.Q))
            {
                if (c == 0)
                {
                    B.transform.Rotate(0, 90, 0);
                    c = 1;
                    _rotate_sound.Play();
                }
                
            }
            if (Input.GetKey(KeyCode.E))
            {
                if (c == 0)
                {
                    B.transform.Rotate(90, 0, 0);
                    c = 1;
                    _rotate_sound.Play();

                }
            }

            if (Input.GetKey(KeyCode.R))
            {
                if (c == 0)
                {
                    B.transform.Rotate(0, 0, 90);
                    c = 1;
                    _rotate_sound.Play();

                }
            }
        }
        else
        {
            SceneManager.LoadScene("ScoreScene");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        /*if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.tag = "Untagged";
            _spawn = false;
        }*/
    }
    void Binge()
    {
        speed = 10f;
        ext = 10;

        //SceneManager.LoadScene("StartScene");
    }
}
