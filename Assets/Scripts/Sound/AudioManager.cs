using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;

    // deletes extra audio manager from scenes
    public static AudioManager instance;

    // sound settings within each audio clip
    void Awake ()
    {

        // deletes extra audio manager from scenes
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
                return;
        }


        // Applying Audio Manager to continuing scenes without disruption
        DontDestroyOnLoad(gameObject);


        // Not really sure what this does
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }


    // theme music plays here
    void Start ()
    {

        Play("Start");
    }


    // finds the source of music 
    public void Play (string name)
    {
       Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }
}
