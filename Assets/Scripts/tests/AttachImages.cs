using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AttachImages : MonoBehaviour
{
    private LoadImages loadImages;
    private string[] image_files;

    public GameObject imagePrefab; // ImageプレハブをInspectorで指定

    // Start is called before the first frame update
    void Start()
    {
        loadImages = this.gameObject.GetComponent<LoadImages>();
        image_files = loadImages.image_files;
    }

    void attachImages()
    {
        foreach (var image in image_files)
        {
            // 画像のパスからスプライトを読み込む
            Sprite sprite = LoadSpriteFromPath(image);

            // Imageプレハブのインスタンスを生成
            GameObject imageObject = Instantiate(imagePrefab);

            // Imageコンポーネントを取得して、スプライトを設定する
            Image imageComponent = imageObject.GetComponent<Image>();
            imageComponent.sprite = sprite;
        }
    }

    // 画像のパスからスプライトを読み込む関数
    Sprite LoadSpriteFromPath(string path)
    {
        // パスからテクスチャを読み込み、スプライトを作成する（適宜エラーチェックを追加してください）
        Texture2D texture = LoadTextureFromPath(path);
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        return sprite;
    }

    // パスからテクスチャを読み込む関数（適宜エラーチェックを追加してください）
    Texture2D LoadTextureFromPath(string path)
    {
        byte[] fileData = File.ReadAllBytes(path);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(fileData);
        return texture;
    }
}
