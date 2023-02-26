using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif
using TMPro;



public class MainUI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI BestScore;
    private string playerName;
    private int highscore;

    // Start is called before the first frame update
    void Start()
    {
        playerName = MainManager.Instance.playerName;
        highscore = MainManager.Instance.highscore;
    }

    // Update is called once per frame
    void Update()
    {
        BestScore.SetText("Highscore from " + playerName + " is: " + highscore);
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
        MainManager.Instance.SaveScore();
    }

    public void SaveScore()
    {
        MainManager.Instance.SaveScore();
    }

    public void LoadScore()
    {
        MainManager.Instance.LoadScore();
        
    }

}
