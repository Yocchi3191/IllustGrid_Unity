using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject imagePrefab;

    private List<string> filePaths;

    private void Start()
    {
        GameObject fileManager = GameObject.Find("FileManager");
        FileManager fileManagerScript = fileManager.GetComponent<FileManager>();
        filePaths = fileManagerScript.GetFilePaths();
    }

    /// <summary>
    /// 画像UIを生成し、UIに画像をアタッチする
    /// </summary>
    /// <param name="path"></param>
    /// <param name="prefab"></param>
    private void GenerateImagePanel(string path, GameObject prefab)
    {
        GameObject prefabInstance = Instantiate(prefab);
    }

    /// <summary>
    /// pathをもとに参照した画像ファイルをTexture2Dとして返す
    /// </summary>
    /// <param name="path"></param>
    /// <returns>画像ファイルを読み込ませたテクスチャ(Texture2D)</returns>
    private Texture2D LoadTexture(string path)
    {
        // Load the image from the path
        byte[] bytes = System.IO.File.ReadAllBytes(path);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(bytes);

        return texture;
    }
}
