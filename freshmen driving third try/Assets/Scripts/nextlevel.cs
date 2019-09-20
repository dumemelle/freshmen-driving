using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    public string[] scenes;
    public int currentscene;
    public string nextscene;
    private void Start()
    {
        scenes = new string[5];
        scenes[0] = "no scene";
        scenes[1] = "level one";
        scenes[2] = "level two";
        scenes[3] = "level three";
        scenes[4] = "level four";
        currentscene = 0;

    }
    public void NextGame ()
    {
        currentscene += 1;
        Debug.Log(currentscene);
        nextscene = scenes[currentscene];
        SceneManager.LoadScene(nextscene, LoadSceneMode.Single);

    }
}
