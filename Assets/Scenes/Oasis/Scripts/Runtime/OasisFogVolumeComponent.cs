using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


[VolumeComponentMenu("Sample Scene/Oasis Fog")]
public class OasisFogVolumeComponent : VolumeComponent
{
    public ClampedFloatParameter Density = new ClampedFloatParameter(0, 0, 0.05f);
    public MinFloatParameter StartDistance = new MinFloatParameter(0.0f, 0.0f);
    public Vector2Parameter HeightRange = new Vector2Parameter(new Vector2(0.0f, 50.0f));
    public ColorParameter Tint = new ColorParameter(UnityEngine.Color.clear, true, false, false);
    public MinFloatParameter SunScatteringIntensity = new MinFloatParameter(2.0f, 0.0f);
}
