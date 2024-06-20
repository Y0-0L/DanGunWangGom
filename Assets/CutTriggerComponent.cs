using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTriggerComponent : MonoBehaviour
{
    public bool isCut = false;
    private void Start()
    {

    }
    
    private void OnMouseOver()
    {
        if (isCut == true) return;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            isCut = true;
            int count = int.Parse(this.gameObject.name.Substring(8, 1));
            this.transform.parent.gameObject.GetComponent<CutLineComponent>().triggers[count] = true;
            this.transform.parent.gameObject.GetComponent<CutLineComponent>().CheckState();
        }
    }
}
