using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewButton : MonoBehaviour
{
    public void LoadingNewScene()
    {
        SceneManager.LoadScene("Main");
    }
    
}