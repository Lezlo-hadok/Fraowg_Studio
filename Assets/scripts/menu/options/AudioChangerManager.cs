using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class AudioChangerManager : MonoBehaviour
{
    internal static AudioChangerManager masterVolume;
    public AudioMixer audioMixer;
    public float sliderValue;
    public Slider slider;

    public void SetMasterVolume(float masterVolume)
    {
        sliderValue = masterVolume;
        audioMixer.SetFloat("MasterVolume", sliderValue);
        
    }
    void Start()
    {
       slider.value = sliderValue;
        SetMasterVolume(sliderValue);
    }
}
