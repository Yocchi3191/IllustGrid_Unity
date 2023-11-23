using UnityEngine;
using SFB;
using System;

public class FolderPathManager : MonoBehaviour
{
    public string folderPath;

    void Start()
    {
        folderPath = string.Empty;

        if (string.IsNullOrEmpty(folderPath))
        {
            var newPath = OpenFileBrowser();
            SetFolderPath(newPath);
        }
    }

    public string GetFolderPath()
    {
        return folderPath;
    }

    private void SetFolderPath(string path)
    {
        folderPath = path;
        Debug.Log(folderPath);
    }

    /// <summary>
    /// ファイル選択ダイアログを開く。プラグインのStandaloneFileBrowserの機能で実装
    /// </summary>
    /// <returns>ファイルパス (string) </returns>
    private string OpenFileBrowser()
    {
        var paths = StandaloneFileBrowser.OpenFolderPanel("フォルダを選んでね！", "", false);

        if (paths.Length > 0)
        {
            return paths[0];
        }
        return String.Empty;
    }
}
