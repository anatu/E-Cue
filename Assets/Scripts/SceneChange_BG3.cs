using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_BG3 : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene("BG4,Classroom", LoadSceneMode.Single);
    }
}