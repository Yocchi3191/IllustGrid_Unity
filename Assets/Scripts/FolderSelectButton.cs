using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FolderSelectButton : MonoBehaviour
{
    /// <summary>
    /// ���݂̃V�[�����ēǍ�����
    /// </summary>
   public void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }
}
