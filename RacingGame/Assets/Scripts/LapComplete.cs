using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    public float RawTime;

    public GameObject RaceFinish;

    void Update() {
    	if (LapsDone == 3) {
    		RaceFinish.SetActive(true);
    	}
    }

    void OnTriggerEnter () {

    	LapsDone += 1;
    	RawTime = PlayerPrefs.GetFloat("RawTime");
    	if (LapTimeManager.RawTime <= RawTime) {
    		if (LapTimeManager.SecondCount <= 9) {
    		SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ".";
    	} else {
    		SecondDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ".";
    	}

    	if (LapTimeManager.MinuteCount <= 9) {
    		MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ".";
    	} else {
    		MinuteDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ".";
    	}

    	MilliDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapTimeManager.MilliCount;
    	}


    	

    	PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
    	PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
    	PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
    	PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

    	LapTimeManager.MinuteCount = 0;
    	LapTimeManager.SecondCount = 0;
    	LapTimeManager.MilliCount = 0;
    	LapTimeManager.RawTime = 0;
    	LapCounter.GetComponent<TMPro.TextMeshProUGUI>().text = "" + LapsDone;

    	HalfLapTrig.SetActive (true);
    	LapCompleteTrig.SetActive (false);
    }

}
