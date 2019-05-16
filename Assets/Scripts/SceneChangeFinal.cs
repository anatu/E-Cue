using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeFinal : MonoBehaviour
{
    void OnEnable() {
        SceneManager.LoadScene("Scene_Final", LoadSceneMode.Single);
    }
}
