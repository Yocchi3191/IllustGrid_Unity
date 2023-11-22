using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public GameObject imagePrefab;
    public GameObject parentObject;

    [SerializeField] private List<string> filePaths;
    [SerializeField] private List<GameObject> imagePanels;

    private void Start()
    {
        imagePanels = new List<GameObject>();

        GameObject fileManager = GameObject.Find("FileManager");
        FileManager fileManagerScript = fileManager.GetComponent<FileManager>();
        filePaths = fileManagerScript.GetFilePaths();

        foreach (string path in filePaths)
        {
            GameObject imagePanel = Instantiate(imagePrefab);
            var imagePanelScript = imagePanel.GetComponent<ImagePanel>();
            imagePanelScript.Path = path;
            imagePanels.Add(imagePanel);
            imagePanel.transform.parent = parentObject.transform;
        }
    }

    
}
