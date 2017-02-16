using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void SingleplayerBtn(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
