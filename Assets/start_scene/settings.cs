using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public GameObject sampleblock;
    public Scrollbar SizeBar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scale = SizeBar.value * 0.1f + 0.2f;
        sampleblock.transform.localScale = new Vector3(scale, scale, scale);




    }
}
