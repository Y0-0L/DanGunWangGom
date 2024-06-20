using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutComponent : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite brokenSprite;
    public bool isBroken = false;
    public GameManager GM;

    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        if (GM.drawMode == false) return;
        if (Input.GetKey(KeyCode.Mouse0) && isBroken == false)
        {
            isBroken = true;
            this.gameObject.GetComponent<SpriteRenderer>().sprite = brokenSprite;
        }
    }
}