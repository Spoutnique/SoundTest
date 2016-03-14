using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SmemS : MonoBehaviour {
	public Text ScoreDisplay;
	private float score;
	private AudioSource musicBox;
	//private float volume;
	public Slider VolumeSlider;
	public Slider PitchSlider;
	public AudioClip[] T = new AudioClip[30];
	private int i,pause;
	public Text PlayCBtext;
	public Toggle PitchToggle;
	private bool pitchToggled;

	void Start () {
		score = 0;
		i = 0;pause = 1;
		pitchToggled = false;
		musicBox = gameObject.GetComponent<AudioSource>();
		musicBox.volume = 0.5f;
		//musicBox.clip = T[i];
		//musicBox.loop = true;
		//musicBox.Play();
		//AudioSource.PlayClipAtPoint(WoodCarvingPartita,new Vector3 (0,0,0),volume);
		//PlayCBtext.text ="playitnow"; //change the text on the button
	
	}


	void Update () {
		if (musicBox.isPlaying)
		score += 1*Time.deltaTime;

		if (!musicBox.isPlaying/*track over*/) pause = 1; //pour contourner le probléme du double click quand track is over

		ScoreDisplay.text = "Score : " + score.ToString();
		Debug.Log(musicBox.isPlaying);

		if (pitchToggled) PitchSlider.value = 1.0f;
		}

	public void PlayCurrent() {
		musicBox.clip = T[i];
		pause *= -1;
		if (pause < 0)
			musicBox.Play();
		else
		musicBox.Pause();
	}

	public void SetVolume () {
		musicBox.volume = VolumeSlider.value;
	}

	public void SetPitch () {
		musicBox.pitch = PitchSlider.value;
	}

	public void SetPitchToogle () {
		pitchToggled = !pitchToggled;
	}

	public void SetSMBros () {
		i = 0;
		//musicBox.clip = T[i];
		PlayCBtext.text = T[i].name;
		}

	public void SetSTB () {
		i = 1;
		//musicBox.clip = T[i];
		PlayCBtext.text = T[i].name;
		}

	public void SetWoodCP () {
		i = 2;
		//musicBox.clip = T[i];
		PlayCBtext.text = T[i].name;
		}

	public void SetBrinstar () {
		i = 3;
		//musicBox.clip = T[i];
		PlayCBtext.text = T[i].name;
		}

	public void SetLWOOT () {
		i = 4;
		//musicBox.clip = T[i];
		PlayCBtext.text = T[i].name;
		}
		

}
