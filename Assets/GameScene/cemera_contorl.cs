using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cemera_contorl : MonoBehaviour
{
    // Start is called before the first frame update

    public Material _meetcolor;
    public GameObject _cam_anchor;
    public Slider _trans;

    void Awake()
    {



    }

    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _cam_anchor.transform.Rotate(0, -3, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _cam_anchor.transform.Rotate(0, 3, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _cam_anchor.transform.Translate(Vector3.up * 0.1f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _cam_anchor.transform.Translate(Vector3.down * 0.1f);

        }

        _meetcolor.color = new Color(200f/255f, 125f/255f, 125f/255f, _trans.value);




    }
}
