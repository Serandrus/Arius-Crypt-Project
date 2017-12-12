using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

    public AudioSource fxSound;
    public AudioSource musicSound;
    
    public static SoundManager instance = null;


    public Slider sonidoMx;
    public Slider sonidoFx;
    


    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;
	
	void Awake ()
    {
        //Si se cambia de escena se destruye el objeto.
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        //DontDestroyOnLoad(gameObject);
	}
	
    public void PlaySingle (AudioClip clip)
    {
        //reproduce los clips.
        fxSound.clip = clip;
        fxSound.Play();
    }
	
    public void RandimizeSFx(params AudioClip [] clips)
    {
        int randomIndex = Random.Range(0, clips.Length);
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);

        fxSound.pitch = randomPitch;
        fxSound.clip = clips[randomIndex];
        fxSound.Play();
    }

    private void Update()
    {
        //En esta parte se establece la relación con los volumenes en cuanto a los sliders.
        musicSound.volume = sonidoMx.value;
        fxSound.volume = sonidoFx.value;
        
    }
}
