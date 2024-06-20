using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // instance 멤버변수는 private하게 선언
    private static GameManager instance = null;

    private void Awake()
    {
        if (null == instance)
        {
            // 씬 시작될때 인스턴스 초기화, 씬을 넘어갈때도 유지되기위한 처리
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // instance가, GameManager가 존재한다면 GameObject 제거 
            Destroy(this.gameObject);
        }
    }

    public int goalNut, totalNut = 0;
    public int day = 1;
    public Canvas mainCanvas, gameCanvas;
    public Button CheckButton;
    public GameObject[] prefab;
    public GameObject currentGarlic;
    public bool drawMode = false;
    public string nextSceneName;

    public void beginGarlicCutting()
    { 
        drawMode = true;
    }

    public void StartGame()
    {
        currentGarlic = Instantiate(prefab[0]);
        currentGarlic.GetComponent<Transform>().rotation = Quaternion.Euler(0,0,Random.Range(0, 360));
    }
    public void ChangeDrawState(bool state)
    {
        drawMode = state;
    }
    public int CheckButtonOnClick()
    {
        drawMode = false;

        int currnenNut = currentGarlic.gameObject.GetComponent<GarlicComponent>().JudgeSucess();
        totalNut += currnenNut;
        if (totalNut >= goalNut)
        {
            nextSceneName = "Ending";
        }
        else
        {
            nextSceneName = "PlayScene";
            day++;
        }
        return totalNut;
    }
    public void SceneChange()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Restart()
    {
        totalNut = 0;
        day = 1;
        drawMode = false;
        SceneManager.LoadScene("Main");
    }
    public void SetGoalNut(int i)
    {
        goalNut = i;
    }
}