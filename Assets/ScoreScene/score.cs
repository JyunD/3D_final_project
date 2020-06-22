using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class score : MonoBehaviour
{
    public Button _btn, rebtn, _exit;
    public GameObject body;
    public GameObject _result;
    public Text ShowScore;
    public Text ShowAteBlocks;
    public PlayerManager pm;
    private float Score = 0;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        _btn.onClick.AddListener(changeScene);
        rebtn.onClick.AddListener(reGame);
        _exit.onClick.AddListener(exitGame);

        anim = body.GetComponent<Animator>();
        _result.SetActive(false);
        Invoke("ShowResult", 3);
        ShowScore.text = Score.ToString();
        ShowAteBlocks.text = "0";

        pm = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowResult()
    {
        Score = SetUI.Score;
        ShowScore.text = System.Math.Round(Score).ToString();
        ShowAteBlocks.text =  SpawnBlock.spawn_num.ToString();
        _result.SetActive(true);
        pm._end = false;
    }

    void Die()
    {
        anim.SetTrigger("die");
    }
    void changeScene()
    {
        _result.SetActive(false);
        SceneManager.LoadScene("StartScene");
    }
    
    void reGame()
    {
        _result.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }

    void exitGame()
    {
        Debug.Log("Goodbye!");

        Application.Quit();
    }
}
