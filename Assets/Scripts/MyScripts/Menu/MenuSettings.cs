using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSettings : MonoBehaviour
{
    public Slider musicSlider;
    public Slider sfxSlider;
    public Slider masterSlider;
    public bool fullscreen = false;

    public void Resolution(int res)
    {
        if (res == 1) Screen.SetResolution(1920, 1080, fullscreen);
        if (res == 2) Screen.SetResolution(1600, 1200, fullscreen);
        if (res == 3) Screen.SetResolution(800, 600, fullscreen);
    }
    public void Quality(int qua)
    {
        QualitySettings.SetQualityLevel(qua);
    }

    public void FullScreenMode()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void LanguageES()
    {
        Language.SetLanguage(Language.Lang.esES);
    }

    public void LanguageUS()
    {
        Language.SetLanguage(Language.Lang.enUS);
    }

    public void ChangeVolume()
    {
        AudioManager.SetMusicVolume(musicSlider.value);
        AudioManager.SetSFXVolume(sfxSlider.value);
        AudioManager.SetMasterVolume(masterSlider.value);
    }
}
