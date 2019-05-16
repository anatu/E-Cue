using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeN : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("y")) {
            SceneManager.LoadScene("Scene_NY", LoadSceneMode.Single);
        } else if(Input.GetKeyDown("n")) {
            SceneManager.LoadScene("Scene_NN", LoadSceneMode.Single);
        }
    }
}