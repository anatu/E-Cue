using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeYY : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("y")) {
            SceneManager.LoadScene("Scene_YYY", LoadSceneMode.Single);
        } else if(Input.GetKeyDown("n")) {
            SceneManager.LoadScene("Scene_YYN", LoadSceneMode.Single);
        }
    }
}
