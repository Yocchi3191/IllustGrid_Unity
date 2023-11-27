using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class FileManager : MonoBehaviour
{
    [SerializeField] private string[] filePaths;
    public GameObject folderPathManager;

    private void Start()
    {
        filePaths = SetFilePaths();
        filePaths = ShuffleList(filePaths);

        foreach (string path in filePaths)
        {
            Debug.Log(path);
        }
    }

    public string[] GetFilePaths()
    {
        return filePaths;
    }

    /// <summary>
    /// folderPathをもとに、Systemのファイルアクセス機能で任意のフォルダ内のpngファイルを取得
    /// </summary>
    /// <returns> 任意のフォルダ内のpngファイル一覧 string[] </returns>
    private string[] SetFilePaths()
    {
        var folderPathManagerScript = folderPathManager.GetComponent<FolderPathManager>();
        string folderPath = folderPathManagerScript.GetFolderPath();
        string[] filePaths = System.IO.Directory.GetFiles(folderPath, "*.png", System.IO.SearchOption.TopDirectoryOnly);
        foreach (var item in filePaths)
        {
            Debug.Log(item);
        }

        return filePaths;
    }

    /// <summary>
    /// 引数に渡したListの中身をシャッフルして返す
    /// </summary>
    /// <param name="originalList"></param>
    /// <returns><シャッフルされたList (List<string>) /returns>
    private string[] ShuffleList(string[] originalList)
    {
        var newList = originalList;
        for (int i = newList.Length - 1; i > 0; i--)
        {
            var j = UnityEngine.Random.Range(0, i + 1);
            var temp = newList[i];
            newList[i] = newList[j];
            newList[j] = temp;
        }
        return newList;
    }
}
