using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Out : MonoBehaviour
{
    public static bool isCollision;//衝突検出変数

    private void OnTriggerExit2D(Collider2D collision)
    {
        isCollision = false;
        SceneManager.LoadScene("GameOver");
    }
}
