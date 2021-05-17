using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PostProcessContr : MonoBehaviour
{
    private PostProcessVolume _activeVolume;
    public int _colorGradingValue = 1;
    public float _vignetteValue = 0f;
    ColorGrading _colorGrading;
    Vignette _vignette;
    
    private void Start()
    {
        var _postProcessVolumes = new List<PostProcessVolume>();
        PostProcessManager.instance.GetActiveVolumes(GetComponent<PostProcessLayer>(), _postProcessVolumes);
        // _activeVolume = _postProcessVolumes.First();
        _activeVolume = _postProcessVolumes[0];
        // _vignette = _postProcessVolumes[3].profile.AddSettings<Vignette>();
        
        if (!_activeVolume.profile.TryGetSettings( out  _colorGrading))
        {
            _colorGrading = _activeVolume.profile.AddSettings<ColorGrading>();
        }
        if (!_activeVolume.profile.TryGetSettings( out  _vignette))
        {
            _vignette = _activeVolume.profile.AddSettings<Vignette>();
        }
        
    }

    private void Update()
    {
        _colorGrading.temperature.value = _colorGradingValue;
        _vignette.intensity.value = _vignetteValue;
    }
}
