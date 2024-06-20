using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicComponent : MonoBehaviour
{
    public CutLineComponent[] m_CLArray;
    public NutComponent[] m_NCArray;
    public GameObject[] SlicedTemplateArrary;
    public int winCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public int JudgeSucess()
    {
        this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        for(int i=0; i<m_CLArray.Length; i++)
        {
            if (i != m_CLArray.Length - 1)
            {
                if (m_NCArray[i].isBroken == false && m_CLArray[i].isSliced == true && m_CLArray[i + 1].isSliced == true)
                {
                    print(i.ToString() + "성공");
                    m_NCArray[i].gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                    m_NCArray[i].gameObject.GetComponent<SpriteRenderer>().sortingOrder = 13;
                    winCount++;
                    SlicedTemplateArrary[i].SetActive(false);
                }
                else
                {
                    print(i.ToString() + "fail!");
                }
            }
            else
            {
                if (m_NCArray[i].isBroken == false && m_CLArray[i].isSliced == true && m_CLArray[0].isSliced == true)
                {
                    print(i.ToString() + "성공");
                    m_NCArray[i].gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
                    m_NCArray[i].gameObject.GetComponent<SpriteRenderer>().sortingOrder = 13;
                    winCount++;
                    SlicedTemplateArrary[i].SetActive(false);
                }
                else
                {
                    print(i.ToString() + "fail!");
                }
            }
        }

        return winCount;
    }
}
