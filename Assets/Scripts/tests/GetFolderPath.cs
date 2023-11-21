using SFB;
using UnityEngine;

public class GetFolderPath : MonoBehaviour
{
    public string folder_path;

    // Start is called before the first frame update
    void Start()
    {
        OpenSFB();
    }

    public void OpenSFB()
    {
        var paths = StandaloneFileBrowser.OpenFolderPanel("Select Folder", "", true);
        folder_path = paths[0];
        Debug.Log(folder_path);
    }
}
