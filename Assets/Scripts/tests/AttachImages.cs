using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AttachImages : MonoBehaviour
{
    private LoadImages loadImages;
    private string[] image_files;

    public GameObject imagePrefab; // Image�v���n�u��Inspector�Ŏw��

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
            // �摜�̃p�X����X�v���C�g��ǂݍ���
            Sprite sprite = LoadSpriteFromPath(image);

            // Image�v���n�u�̃C���X�^���X�𐶐�
            GameObject imageObject = Instantiate(imagePrefab);

            // Image�R���|�[�l���g���擾���āA�X�v���C�g��ݒ肷��
            Image imageComponent = imageObject.GetComponent<Image>();
            imageComponent.sprite = sprite;
        }
    }

    // �摜�̃p�X����X�v���C�g��ǂݍ��ފ֐�
    Sprite LoadSpriteFromPath(string path)
    {
        // �p�X����e�N�X�`����ǂݍ��݁A�X�v���C�g���쐬����i�K�X�G���[�`�F�b�N��ǉ����Ă��������j
        Texture2D texture = LoadTextureFromPath(path);
        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
        return sprite;
    }

    // �p�X����e�N�X�`����ǂݍ��ފ֐��i�K�X�G���[�`�F�b�N��ǉ����Ă��������j
    Texture2D LoadTextureFromPath(string path)
    {
        byte[] fileData = File.ReadAllBytes(path);
        Texture2D texture = new Texture2D(2, 2);
        texture.LoadImage(fileData);
        return texture;
    }
}
