using UnityEngine;
using SFB;
using System;

public class FolderPathManager : MonoBehaviour
{
    public string folderPath;

    // Start is called before the first frame update
    void Start()
    {
        folderPath = string.Empty;

        if (string.IsNullOrEmpty(folderPath))
        {
            OpenSFB();
        }
    }

    public string GetFolderPath()
    {
        return folderPath;
    }

    public void SetFolderPath(string path)
    {
        folderPath = path;
        Debug.Log(folderPath);
    }

    public void OpenSFB()
    {
        var paths = StandaloneFileBrowser.OpenFolderPanel("フォルダを選んでね！", "", false);

        if (paths.Length > 0)
        {
            SetFolderPath(paths[0]);
        }
    }
}
