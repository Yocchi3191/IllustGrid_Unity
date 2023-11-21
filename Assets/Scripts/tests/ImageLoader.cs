using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class ImageLoader : MonoBehaviour
{
    public string folderPath; // Resources�t�H���_���̉摜�t�H���_�ւ̃p�X�i��: "Images"�j

    void Start()
    {
        // �t�H���_���̑S�Ẵt�@�C�������擾����
        string[] fileNames = Directory.GetFiles(Application.dataPath + "/Resources/" + folderPath, "*.png");

        // �擾�����t�@�C���������X�g�Ɋi�[����
        List<string> filePaths = new List<string>();
        foreach (string fileName in fileNames)
        {
            // �t�@�C���p�X��Resources.Load�Ŏg�p�ł���`���ɕϊ�����
            string filePath = fileName.Replace(Application.dataPath + "/Resources/", "").Replace(".png", "");
            filePaths.Add(filePath);
        }

        // �t�@�C���p�X�̃��X�g��\������i�f�o�b�O�ړI�j
        foreach (string filePath in filePaths)
        {
            Debug.Log("File Path: " + filePath);
        }


    }
}
