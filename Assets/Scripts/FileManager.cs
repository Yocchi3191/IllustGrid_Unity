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
    /// folderPath�����ƂɁASystem�̃t�@�C���A�N�Z�X�@�\�ŔC�ӂ̃t�H���_����png�t�@�C�����擾
    /// </summary>
    /// <returns> �C�ӂ̃t�H���_����png�t�@�C���ꗗ string[] </returns>
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
    /// �����ɓn����List�̒��g���V���b�t�����ĕԂ�
    /// </summary>
    /// <param name="originalList"></param>
    /// <returns><�V���b�t�����ꂽList (List<string>) /returns>
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
