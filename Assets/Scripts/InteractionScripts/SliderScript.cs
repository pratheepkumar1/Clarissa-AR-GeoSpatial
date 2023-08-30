// using Google.Protobuf.WellKnownTypes;
// using Newtonsoft.Json.Linq;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class SliderScript : MonoBehaviour
// {
//     [SerializeField]
//     private Slider yPositionSlider;
//     void Start()
//     {
//         yPositionSlider = GameObject.Find("Height").GetComponent<Slider>();
//         yPositionSlider.minValue = -10;
//         yPositionSlider.maxValue = 10;
//         yPositionSlider.value = 1;
//         yPositionSlider.onValueChanged.AddListener(HeightSliderUpdate);
//     }
//     void HeightSliderUpdate(float value)
//     {
//         transform.localScale = new Vector3( value,  value, value);
//     }
//     void RotationSliderUpdate(float value)
//     {
//         transform.localEulerAngles = new Vector3(transform.localRotation.x,  value, transform.localRotation.z);
//     }
//     private void Update()
//     {
//         //yPositionSlider.value = transform.localPosition.y;
//     }
// }
