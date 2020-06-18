using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SetUI : MonoBehaviour
{
    public Text SpendTime;
    public Text Ate_block;
    
    public static float Score;
    public static int spawn_num;
    private string defaultString;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        spawn_num = 0;
        defaultString = "Eating Time ";
        SpendTime.text = defaultString + System.Math.Round(Score).ToString() + " second";
        Ate_block.text = "Ate " + spawn_num.ToString() + " blocks.";
        
    }

    // Update is called once per frame
    void Update()
    {
        Score += Time.deltaTime;
        spawn_num = SpawnBlock.spawn_num;
        SpendTime.text = defaultString + System.Math.Round(Score).ToString() + " seconds";
        Ate_block.text = "Ate " + spawn_num.ToString() + " blocks.";
    }

    
}
