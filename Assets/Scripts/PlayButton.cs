using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private GameObject fromCanvas;
    [SerializeField] private GameObject toCanvas;

    public void OnClickCanvasChangeButton(int timeScaleTo = 1)
    {
        Time.timeScale = timeScaleTo;

        if (fromCanvas)
        {
            fromCanvas.SetActive(false);
        }

        if (toCanvas)
        {
            toCanvas.SetActive(true);
        }
    }

    public void OnClickLevelSelect(int targetBuildIndex)
    {
        SceneManager.LoadScene(targetBuildIndex);
    }

}
