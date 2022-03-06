using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject levelsMenu;

    private void Start()
    {
        mainMenu.SetActive(true);
        levelsMenu.SetActive(false);
    }

    public void OnClickLevelSelect(int targetBuildIndex)
    {
        SceneManager.LoadScene(targetBuildIndex);
        if(targetBuildIndex == 1)
        {
            Time.timeScale = 1;
        }
    }

}

