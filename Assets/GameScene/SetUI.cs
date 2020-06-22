using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SetUI : MonoBehaviour
{
    public Text SpendTime;
    public Text Ate_block;
    public PlayerManager pm;
    private string defaultString;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        pm = FindObjectOfType<PlayerManager>();
        pm.score = 0;
        pm.spawn_num = 0;
        defaultString = "Eating Time ";
        SpendTime.text = defaultString + System.Math.Round(pm.score).ToString() + " second";
        Ate_block.text = "Ate " + pm.spawn_num.ToString() + " blocks.";
        

    }

    // Update is called once per frame
    void Update()
    {
        pm.score += Time.deltaTime;
        SpendTime.text = defaultString + System.Math.Round(pm.score).ToString() + " seconds";
        Ate_block.text = "Ate " + pm.spawn_num.ToString() + " blocks.";
    }

    
}
