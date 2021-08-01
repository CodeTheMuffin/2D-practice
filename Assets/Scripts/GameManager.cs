using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameUtility;
using System.IO;

public class GameManager : MonoBehaviour
{
    private string version = "v0.0.0";
	
    public Text version_text;

    void Start()
    {
        string version_path = "Assets/version.txt";
        StreamReader reader = new StreamReader(version_path);
        version_text.text = reader.ReadLine(); //Assumes the version number is on the first line
        reader.Close();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
