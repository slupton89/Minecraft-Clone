using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager> {

    [SerializeField]
    AudioClip jump;
    [SerializeField]
    AudioClip punch;
    [SerializeField]
    AudioClip build;

    public AudioClip Jump {
        get {
            return jump;
        }
    }

    public AudioClip Punch {
        get {
            return punch;
        }
    }

    public AudioClip Build {
        get {
            return build;
        }
    }

}
