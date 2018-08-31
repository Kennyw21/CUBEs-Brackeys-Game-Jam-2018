using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class Saturation_Manager : MonoBehaviour {

    ColorCorrectionCurves cam_effect;

    public GameObject player;
    public GameObject destination;
    public float original_distance;
    public float current_distance;
    public float saturation_value;
    public float distance_ratio;

	// Use this for initialization
	void Start () {
        cam_effect = GetComponent<ColorCorrectionCurves>();
        cam_effect.saturation = 1;
        saturation_value = cam_effect.saturation;
        original_distance = player.transform.position.z - destination.transform.position.z;
        original_distance = Mathf.Abs(original_distance);
	}
	
	// Update is called once per frame
	void Update () {
        if (cam_effect.saturation < 0.09)
        {
            cam_effect.saturation = 0;
            this.enabled = false;
        }
        current_distance = player.transform.position.z - destination.transform.position.z;
        current_distance = Mathf.Abs(current_distance);
        distance_ratio = current_distance / original_distance;
        cam_effect.saturation = distance_ratio;
        saturation_value = cam_effect.saturation;
	}
}
