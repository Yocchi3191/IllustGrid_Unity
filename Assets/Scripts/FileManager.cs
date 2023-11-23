using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class FileManager : MonoBehaviour
{
    [SerializeField] private string folderPath;
    [SerializeField] private List<string> filePaths;
    public GameObject folderPathManager;

    private void Start()
    {
        SetFolderPath();
        filePaths = SetFilePaths();
        filePaths = ShuffleList(filePaths);

        foreach (string path in filePaths)
        {
            Debug.Log(path);
        }
    }

    public string GetFolderPath()
    {
        return folderPath;
    }

    public void SetFolderPath()
    {
        var folderPathScript = folderPathManager.GetComponent<FolderPathManager>();
        folderPath = folderPathScript.GetFolderPath();
    }

    public List<string> GetFilePaths()
    {
        return filePaths;
    }

    private List<string> SetFilePaths()
    {
        string folderPath = GetFolderPath();
        string[] folder = System.IO.Directory.GetFiles(folderPath, "*.png", System.IO.SearchOption.TopDirectoryOnly);
        filePaths = new List<string>(folder);

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
    private List<string> ShuffleList(List<string> originalList)
    {
        var newList = originalList;
        for (int i = newList.Count - 1; i > 0; i--)
        {
            var j = Random.Range(0, i + 1);
            var temp = newList[i];
            newList[i] = newList[j];
            newList[j] = temp;
        }
        return newList;
    }
}
