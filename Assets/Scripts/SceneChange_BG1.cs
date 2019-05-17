using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange_BG1 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene("BG2,House", LoadSceneMode.Single);
    }
}
