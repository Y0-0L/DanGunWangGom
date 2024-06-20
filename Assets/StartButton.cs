using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public GameManager GM;
    public Button DebugButton;
    public Text debugText;

    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        this.GetComponent<Button>().onClick.AddListener(StartGame);
        DebugButton.onClick.AddListener(SetGoalNut);
    }

    // Update is called once per frame
    void StartGame()
    {
        GM.SceneChange();
    }
    private void SetGoalNut()
    {
        GM.SetGoalNut(int.Parse(debugText.text));
    }
}
