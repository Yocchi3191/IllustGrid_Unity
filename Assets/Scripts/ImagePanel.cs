using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagePanel : MonoBehaviour
{
    [SerializeField] private string path;
    [SerializeField] private Texture2D texture;

    public string Path
    {
        get { return path; }
        set { path = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject imagePanel = gameObject;
        var image = imagePanel.GetComponent<Image>();

        texture = LoadTexture(Path);
        image.sprite = NewTexture(texture);
        image.preserveAspect = true;
    }

    /// <summary>
    /// pathをもとに参照した画像ファイルのテクスチャ返す
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

    /// <summary>
    /// 引数に渡したテクスチャデータを自分のテクスチャとしてアタッチする
    /// </summary>
    /// <param name="texture"></param>
    private Sprite NewTexture(Texture2D texture)
    {
        Rect rect = new Rect(0, 0, texture.width, texture.height);
        var newSprite = Sprite.Create(texture, rect, Vector2.zero);
        return newSprite;
    }
}
