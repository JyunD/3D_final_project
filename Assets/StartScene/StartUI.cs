using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartUI : MonoBehaviour
{
    public InputField _UserName;
    //public Dropdown _Skin;
    public Button _StartGame, _exit;
    public Slider _SizeSlider;
    public Slider _SpeedSlider;
    public PlayerManager playerManager;
    public GameObject sampleblock;

    public GameObject panel;

    public Camera _MainCamera;
    public Camera _BlockCamera;
    public AudioSource _startgamesound;



    void Awake()
    {
        Debug.Log("Awake");
        playerManager = FindObjectOfType<PlayerManager>();
        _MainCamera.enabled = true;
        _BlockCamera.enabled = false;
        panel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        _StartGame.onClick.AddListener(changeScene);
        _exit.onClick.AddListener(exitGame);

    }

    void changeScene()
    {
        _startgamesound.Play();
        panel.SetActive(false);
        Invoke("StartGame", 1.8f);
    }
    void StartGame()
    {
        playerManager.user_name = _UserName.text.ToString();
        playerManager.block_size = _SizeSlider.value;
        playerManager.block_speed = _SpeedSlider.value;
        //playerManager.gameObject.GetComponent<Rigidbody>().useGravity = true;
        SceneManager.LoadScene("GameScene");
        Debug.Log(playerManager.block_size);
    }

    private void Update()
    {
        sampleblock.transform.localScale = new Vector3(_SizeSlider.value, _SizeSlider.value, _SizeSlider.value);
    }

    void exitGame()
    {
        Debug.Log("Goodbye!");

        Application.Quit();
    }
}
