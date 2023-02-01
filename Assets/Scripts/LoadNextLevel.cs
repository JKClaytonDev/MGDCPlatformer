using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]
public class LoadNextLevel : MonoBehaviour
{
    public string sceneName;

    private void OnCollisionEnter(Collision collision)
    {
        if (sceneName != null && sceneName.Length > 0)
            SceneManager.LoadScene(sceneName);
        else
            Debug.LogWarning("sceneName not set, unable to load next scene.");
    }
}
