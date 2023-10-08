using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Durum : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    public void OyunaDevam()
    {
        panel.SetActive(false);
    }

    public void YenidenDene()
    {
        SceneManager.LoadScene(0);
    }

    public void OyundanÇýk()
    {
        Application.Quit();
    }
}
