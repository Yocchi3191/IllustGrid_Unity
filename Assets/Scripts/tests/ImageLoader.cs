using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class ImageLoader : MonoBehaviour
{
    public string folderPath; // Resourcesフォルダ内の画像フォルダへのパス（例: "Images"）

    void Start()
    {
        // フォルダ内の全てのファイル名を取得する
        string[] fileNames = Directory.GetFiles(Application.dataPath + "/Resources/" + folderPath, "*.png");

        // 取得したファイル名をリストに格納する
        List<string> filePaths = new List<string>();
        foreach (string fileName in fileNames)
        {
            // ファイルパスをResources.Loadで使用できる形式に変換する
            string filePath = fileName.Replace(Application.dataPath + "/Resources/", "").Replace(".png", "");
            filePaths.Add(filePath);
        }

        // ファイルパスのリストを表示する（デバッグ目的）
        foreach (string filePath in filePaths)
        {
            Debug.Log("File Path: " + filePath);
        }


    }
}
