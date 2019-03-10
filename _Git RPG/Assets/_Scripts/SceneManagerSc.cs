using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerSc : MonoBehaviour
{
    public void LoadScene(int loadScene)
    {
        SceneManager.LoadScene(loadScene);
    }
}
