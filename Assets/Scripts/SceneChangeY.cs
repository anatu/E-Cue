using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeY : MonoBehaviour
{
    void Update()
    {
        if((Input.GetKeyDown("y")) || (Input.GetKey(KeyCode.Mouse0))) {
            SceneManager.LoadScene("Scene_YY", LoadSceneMode.Single);
        } else if((Input.GetKeyDown("n")) || (Input.GetKey(KeyCode.Mouse1))) {
            SceneManager.LoadScene("Scene_YN", LoadSceneMode.Single);
        }
    }
}
