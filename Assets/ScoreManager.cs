using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameManager m_GM;
    public Button restart;
    // Start is called before the first frame update
    void Start()
    {
        m_GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        this.GetComponent<Text>().text = m_GM.day.ToString();
        restart.GetComponent<Button>().onClick.AddListener(Restart);
    }

    // Update is called once per frame
    void Restart()
    {
        m_GM.Restart();
    }
}
