using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RsultManager : MonoBehaviour
{
    public Sprite[] resultBears;
    public string[] resultText;
    public Image human;
    public Text resultScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetResultBear()
    {
        int randNum = Random.Range(0, resultBears.Length);

        human.sprite = resultBears[randNum];
        resultScript.text = resultText[randNum];

    }
}
