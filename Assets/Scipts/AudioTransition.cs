using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
/*//1 maak eeert een ref naar de audio mixer
public class AudioTransition : MonoBehaviour {
    
    public AudioMixer mixer;// 2 hierin sleep je je mastermixer.
                            // je wilt tussen snapshopts mixen, so u need to vars. 1.normal en 2.lowvolumesnapshot

    private AudioMixerSnapshot normalSnapshot;
    private AudioMixerSnapshot lowVolumeSnapshot;

    void Start () {
		normalSnapshot = mixer.FindSnapshot//(["naam" van de snapshot die je in de mixer hebt gegeven, hopfdlettergevoelig]);
        lowVolumeSnapshot2 = mixer.FindSnapshot//(["naam" van de snapshot die je in de mixer hebt gegeven, hopfdlettergevoelig]);
        // let erop dat naam vd findfunctie echt overeen jomt met in de mixerinspector
    }
	
	void Update () {
        // ga over naar de andere snapshot als je spatie indrukt
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mixer.ClearFloat("MasterVolume"); // op deze manier gaaat ie alsnog mee naar de volgende snapshot
            // ga nu in overgang naar de low volume snapshot
            lowVolumeSnapshot.TransitionTo(.5f); // gaat er in halve seconde heen
        }
        // zolng je lmb klick agaat volume omhoog
        // mouse number 0 = links 1 = rechts 2 = mousewheel
        if (Imput.GetMouseButton(0))
        {
            float currentVolume;
            mixer.GetFloat("MasterVolume", out currentVolume; //begin met out omdat het een output is)

            mixer.SetFloat("MasterVolume", currentVolume + 0.1f);
            // naam =  naamgegeven bij de exposed parameter
        }

	}
}
*/