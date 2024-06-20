using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutLineComponent : MonoBehaviour
{
    public bool[] triggers = new bool[3];
    public bool isSliced = false;

    public void CheckState()
    {
        if (triggers[0] && triggers[1] && triggers[2])
        {
            isSliced = true;
        }
    }
}