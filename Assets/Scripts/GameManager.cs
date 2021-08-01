using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GameUtility;

public class GameManager : MonoBehaviour
{
    private string version = "v0.1.2";
	
    public Text version_text;

    void Start()
    {
        version_text.text = version;
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
