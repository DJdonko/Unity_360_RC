using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    //public GameObject PressedButton;
    public GameObject SceneToDissapear;
    public GameObject SceneToAppear;
    // Start is called before the first frame update
    void Start()
    {
       // PressedButton.onClick.AddListener();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleScene()
    {
        SceneToDissapear.SetActive (false);
        SceneToAppear.SetActive (true);
    }
}
