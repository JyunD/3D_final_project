using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    static PlayerManager Instance;
    public float block_speed;
    public float block_size;
    public float score;
    public string user_name;
    public int spawn_num = 0;
    public bool _end = false;


    private void Awake()
    {
        Debug.Log("Test Game Awake");
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            SceneManager.LoadScene("StartScene");
        }
    }

}
