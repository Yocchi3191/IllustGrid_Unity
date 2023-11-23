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
    /// �t�@�C���I���_�C�A���O���J���B�v���O�C����StandaloneFileBrowser�̋@�\�Ŏ���
    /// </summary>
    /// <returns>�t�@�C���p�X (string) </returns>
    private string OpenFileBrowser()
    {
        var paths = StandaloneFileBrowser.OpenFolderPanel("�t�H���_��I��łˁI", "", false);

        if (paths.Length > 0)
        {
            return paths[0];
        }
        return String.Empty;
    }
}
