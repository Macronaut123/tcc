using UnityEngine;
using System.Collections;

public class SliderSetup : MonoBehaviour {

    private UISlider _Volumeslider;

    // Use this for initialization
    void Start()
    {
        _Volumeslider = gameObject.GetComponent<UISlider>();
        EventDelegate.Set(_Volumeslider.onChange, OnValueChange);
    }

    void OnValueChange()
    {
        AudioListener.volume = _Volumeslider.value;
        NGUITools.soundVolume = _Volumeslider.value;
    }
}
