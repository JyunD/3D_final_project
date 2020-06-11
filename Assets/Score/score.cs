using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class score : MonoBehaviour
{
    public Button _btn;
    public GameObject body;
    public GameObject _result;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        _btn.onClick.AddListener(Die);
        anim = body.GetComponent<Animator>();
        _result.SetActive(false);

        Invoke("ShowResult", 6);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowResult()
    {
        _result.SetActive(true);
    }

    void Die()
    {
        anim.SetTrigger("die");


    }
}
