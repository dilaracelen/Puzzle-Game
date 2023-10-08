using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Mixer : MonoBehaviour
{
    public AudioMixer mixer;

    public GameObject panel;

    public Slider master;
    public Slider ding;
    public Slider music;

    void SetSliders()
    {
        // Mixerde verdiðimiz parametrelerin adýyla ayný olmalý.
        master.value = PlayerPrefs.GetFloat("Master");
        ding.value = PlayerPrefs.GetFloat("Ding");
        music.value = PlayerPrefs.GetFloat("Music");
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("Master"))
        {
            mixer.SetFloat("Master", PlayerPrefs.GetFloat("Master"));
            mixer.SetFloat("Ding", PlayerPrefs.GetFloat("Ding"));
            mixer.SetFloat("Music", PlayerPrefs.GetFloat("Music"));

            SetSliders();
        }
        else
        {
            SetSliders();
        }
    }

    public void UpdateMaster()
    {
        mixer.SetFloat("Master", master.value);
        PlayerPrefs.SetFloat("Master", master.value);
    }

    public void UpdateSFX()
    {
        mixer.SetFloat("Ding", ding.value);
        PlayerPrefs.SetFloat("Ding", ding.value);
    }

    public void UpdateMusic()
    {
        mixer.SetFloat("Music", music.value);
        PlayerPrefs.SetFloat("Music", music.value);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            panel.SetActive(!panel.activeInHierarchy);
        }
    }
}
