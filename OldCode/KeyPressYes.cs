using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPressYes : MonoBehaviour
{
    // Update is called once per frame
    void OnEnable()
    {
        if(Input.GetMouseButtonDown(0))
        {
            print("left click");
        }
    }
}
