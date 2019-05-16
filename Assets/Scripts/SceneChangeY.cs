using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeY : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("y")) {
            SceneManager.LoadScene("Scene_YY", LoadSceneMode.Single);
        } else if(Input.GetKeyDown("n")) {
            SceneManager.LoadScene("Scene_YN", LoadSceneMode.Single);
        }
    }
}
