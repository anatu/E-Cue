using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_BG0 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("BG1,Classroom", LoadSceneMode.Single);
    }
}
