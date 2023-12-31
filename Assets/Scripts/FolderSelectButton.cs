using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FolderSelectButton : MonoBehaviour
{
    /// <summary>
    /// 現在のシーンを再読込する
    /// </summary>
    public void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
