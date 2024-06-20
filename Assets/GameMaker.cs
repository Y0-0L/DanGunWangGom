using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMaker : MonoBehaviour
{
    public GameManager m_GM;
    public Animator bearAni;
    public GameObject nightCanvas;
    public GameObject resultText, b4Text, checkButton, bear, dayText, brushExample;
    public GameObject ResultText, resultCanvas, resutlBearCanvas;
    // Start is called before the first frame update
    void Start()
    {
        m_GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        m_GM.StartGame();
        dayText.GetComponent<Text>().text = "Day " + m_GM.day.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void beginCutting()
    {
        m_GM.beginGarlicCutting();
    }
    public void AniTrigger()
    {
        bearAni.SetTrigger("toSleeping");
    }
    public void Check()
    {
        int totalNut = m_GM.CheckButtonOnClick();

        nightCanvas.SetActive(false);

        b4Text.SetActive(false);
        checkButton.SetActive(false);

        resultText.GetComponent<Text>().text = totalNut.ToString() + "/" + m_GM.goalNut.ToString();

        Invoke("Check_Delayed", 2.0f);
    }
    public void Check_Delayed()
    {
        resultCanvas.SetActive(true);
        resutlBearCanvas.SetActive(true);
        bear.SetActive(false);
        brushExample.SetActive(false);
    }
    public void sceneChange()
    {
        m_GM.SceneChange();
        SceneManager.LoadScene(m_GM.nextSceneName);
    }
}
