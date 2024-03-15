using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MEDIACONTROLLER : MonoBehaviour {
    public bool playing;
    public Button botonplay;
    public Sprite pause;
    public Sprite play;
    public GameObject mediaplayercontroler;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void valuechangue() {
        if (playing == true)
        {
            botonplay.image.sprite = play;
            mediaplayercontroler.GetComponent<MediaPlayerCtrl>().Pause();
            playing = false;
        }
        else {

            botonplay.image.sprite = pause;
            mediaplayercontroler.GetComponent<MediaPlayerCtrl>().Play();
            playing = true;

        }

      
          
    }


    public void salir()
    {

        playing = true;
        botonplay.image.sprite = pause;
    }

}
