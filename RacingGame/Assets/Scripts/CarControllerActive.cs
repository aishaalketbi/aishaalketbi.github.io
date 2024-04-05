using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControllerActive : MonoBehaviour {

    public GameObject CarControl;
    public GameObject Car01;

    void Start() {
        CarControl.GetComponent<CarUserControl>().enabled = true;
        Car01.GetComponent<CarAIControl>().enabled = true;
    }
}

