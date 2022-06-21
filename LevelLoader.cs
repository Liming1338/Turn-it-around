using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void FirstLevelLoad()
    {
        SceneManager.LoadScene("LVL1");
    }

    public void SecondLevelLoad()
    {
        SceneManager.LoadScene("LVL2");
    }

    public void ThirdLevelLoad()
    {
        SceneManager.LoadScene("LVL3");
    }

    public void FouthLevelLoad()
    {
        SceneManager.LoadScene("LVL4");
    }

    public void FiveLevelLoad()
    {
        SceneManager.LoadScene("LVL5");
    }
}