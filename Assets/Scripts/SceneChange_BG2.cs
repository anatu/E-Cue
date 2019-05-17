using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_BG2 : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("BG3,Room", LoadSceneMode.Single);
    }
}