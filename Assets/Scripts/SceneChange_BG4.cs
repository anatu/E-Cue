using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_BG4 : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("BG5,Park", LoadSceneMode.Single);
    }
}
