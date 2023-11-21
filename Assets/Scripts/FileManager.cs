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

    public void SetFilePaths()
    {
        string folderPath = GetFolderPath();
        string[] folder = System.IO.Directory.GetFiles(folderPath, "*.png", System.IO.SearchOption.TopDirectoryOnly);
        filePaths = new List<string>(folder);

        foreach (var item in filePaths)
        {
            Debug.Log(item);
        }
    }
}
