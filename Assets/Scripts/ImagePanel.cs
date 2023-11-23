using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        texture = LoadTexture(Path);
        AttachTexture(texture);
    }

    /// <summary>
    /// path�����ƂɎQ�Ƃ����摜�t�@�C���̃e�N�X�`���Ԃ�
    /// </summary>
    /// <param name="path"></param>
    /// <returns>�摜�t�@�C����ǂݍ��܂����e�N�X�`��(Texture2D)</returns>
    private Texture2D LoadTexture(string path)
    {
        // Load the image from the path
        byte[] bytes = System.IO.File.ReadAllBytes(path);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(bytes);

        return texture;
    }

    /// <summary>
    /// �����ɓn�����e�N�X�`���f�[�^�������̃e�N�X�`���Ƃ��ăA�^�b�`����
    /// </summary>
    /// <param name="texture"></param>
    private void AttachTexture(Texture2D texture)
    {
        GameObject imagePanel = gameObject;
        Rect rect = new Rect(0, 0, texture.width, texture.height);
        imagePanel.GetComponent<UnityEngine.UI.Image>().sprite = Sprite.Create(texture, rect, Vector2.zero);
    }
}
