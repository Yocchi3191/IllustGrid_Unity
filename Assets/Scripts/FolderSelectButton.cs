using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FolderSelectButton : MonoBehaviour
{
    /// <summary>
    /// Œ»İ‚ÌƒV[ƒ“‚ğÄ“Ç‚·‚é
    /// </summary>
   public void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
