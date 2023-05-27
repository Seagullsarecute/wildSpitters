using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene: MonoBehaviour
{
    public void Change_scene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
