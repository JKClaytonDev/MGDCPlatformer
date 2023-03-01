using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class arcadeControls : MonoBehaviour
{
    float timer;
    public GUIStyle customStyle;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnGUI()
    {
        customStyle.fontSize = 100;
        GUI.Label(new Rect(960, 100, 4000, 1000), "Time: " + (Mathf.Round(timer*10)/10));
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
