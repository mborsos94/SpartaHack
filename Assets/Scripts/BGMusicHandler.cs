using UnityEngine;
using System.Collections;

public class BGMusicHandler : MonoBehaviour {
    public AudioClip[] music;
	// Use this for initialization
	void Start () {
        int selectedClip;
        selectedClip = UnityEngine.Random.Range(0, music.Length);
        this.GetComponent<AudioSource>().PlayOneShot(music[selectedClip]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
