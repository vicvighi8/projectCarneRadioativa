using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{
    public void jogar()
    {
        SceneManager.LoadScene(1);
    }

    public void gototelainicial()
    {
        SceneManager.LoadScene(0);
    }

    public void creditos()
    {
        SceneManager.LoadScene(2);
    }
}
