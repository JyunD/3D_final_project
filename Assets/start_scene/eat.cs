using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class eat : MonoBehaviour
{

    public Button _StartGame;
    Animator anim;

    public Camera _MainCamera;
    public Camera _BlockCamera;

    // Start is called before the first frame update


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        _StartGame.onClick.AddListener(StartEat);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartEat()
    {
        _MainCamera.enabled = false;
        _BlockCamera.enabled = true;
        Debug.Log("Eat trigger");
        anim.SetTrigger("start");
    }
}

