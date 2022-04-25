using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSaveController : MonoBehaviour
{
    [SerializeField] private Slider volumeslider = null;
    [SerializeField] private Text volumeTextUI = null;

    private void Start(){
        LoadValues();
    }
    public void VolumeSLider(float volume){
        volumeTextUI.text = volume.ToString("0.0");
    }
    public void SaveVolumeButton(){
        float volumeValue = volumeslider.value;
        PlayerPrefs.SetFloat("VolumeValue", volumeValue);
        LoadValues();
    }
    void LoadValues(){
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        volumeslider.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
