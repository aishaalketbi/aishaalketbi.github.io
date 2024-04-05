using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject CarControls;
    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine (CountStart()); 
    }

    IEnumerator CountStart(){
    	LapTimer.SetActive (false);
    	yield return new WaitForSeconds (0.5f);
    	CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "3";
    	GetReady.Play ();
    	CountDown.SetActive (true);
    	yield return new WaitForSeconds (1);
    	CountDown.SetActive (false);
    	CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "2";
    	GetReady.Play ();
    	CountDown.SetActive (true);
    	yield return new WaitForSeconds (1);
    	CountDown.SetActive (false);
    	CountDown.GetComponent<TMPro.TextMeshProUGUI>().text = "1";
    	GetReady.Play ();
    	CountDown.SetActive (true);
    	yield return new WaitForSeconds (1);
    	CountDown.SetActive (false);
    	GoAudio.Play ();
    	LapTimer.SetActive (true);
    	CarControls.SetActive (true);
    }

    
}
