using UnityEngine;
using System.IO;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using Unity.VisualScripting;

public class LoadImages : MonoBehaviour
{
    private GetFolderPath getFolderPath;
    private string folder_path;

    public string[] image_files;

    // Start is called before the first frame update
    void Start()
    {
        getFolderPath = this.gameObject.GetComponent<GetFolderPath>();
        folder_path = getFolderPath.folder_path;

        loadImages();
    }

    void loadImages()
    {
        folder_path = getFolderPath.folder_path;
        //folder_path = @"C:\Users\donch\ダウンロード";
        image_files = Directory.GetFiles(folder_path, "*.jpg");
        foreach (var item in image_files)
        {
            Debug.Log(item);
        }
    }
}
