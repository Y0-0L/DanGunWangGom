using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw_ : MonoBehaviour
{
    public Camera m_camera;
    public GameObject brush;
    public GameManager gameManager;
    LineRenderer currentLR;
    
    Vector2 lastPos;
    private void Start()
    {
        if (gameManager == null)
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        }
    }
    private void Update()
    {
        if (gameManager.drawMode == false)
        {
            return;
        }
        Draw();
    }

    void Draw()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            CreateBrush();
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);
            if (mousePos != lastPos)
            {
                AdddAPoint(mousePos);
                lastPos = mousePos;
            }
        }
        else
        {
            currentLR = null;
        }
    }

    void CreateBrush()
    {
        GameObject brushInstance = Instantiate(brush,brush.GetComponent<Transform>());
        currentLR = brushInstance.GetComponent<LineRenderer>();

        Vector2 mousePos = m_camera.ScreenToWorldPoint(Input.mousePosition);

        currentLR.SetPosition(0, mousePos);
        currentLR.SetPosition(1, mousePos);

    }

    void AdddAPoint(Vector2 pointPos)
    {
        currentLR.positionCount++;
        int positionIndex = currentLR.positionCount - 1;
        currentLR.SetPosition(positionIndex, pointPos);
    }
}
