using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MusicManager : MonoBehaviour
{
    public AudioClip soundLost;
    public AudioClip soundFight;
    public List<AudioClip> soundTrack;
    public List<AudioClip> MusicList;
    public AudioSource soundEffect;
    AudioSource audioData;

    void Start()
    {
        audioData = this.gameObject.GetComponent<AudioSource>();
        StartCoroutine(WaitMusic(2f));
    }

    IEnumerator WaitMusic(float waitTurnTime)
    {
        yield return new WaitForSeconds(waitTurnTime);
        Music();
    }

    void Music()
    {
        if (MusicList.Count > 0)
        {
            int randomSong = Random.Range(0, MusicList.Count);
            GetComponent<AudioSource>().clip = MusicList[randomSong];
            audioData.Play(0);
            MusicList.Remove(MusicList[randomSong]);
            StartCoroutine(WaitMusic(audioData.clip.length));
        }
        else
        {
            foreach (AudioClip soundTrackList in soundTrack.ToList())
            {
                MusicList.Add(soundTrackList);
            }
            Music();
        }
    }

    public void FightSound()
    {
        StartCoroutine(PlayFight(2f));
    }

    IEnumerator PlayFight(float waitTurnTime)
    {
        soundEffect.volume = 1;
        yield return new WaitForSeconds(waitTurnTime);
        soundEffect.volume = 0;
    }

    public void EnterLost()
    {
        soundEffect.clip = soundLost;
        soundEffect.volume = 1;
        soundEffect.Play(0);
        GetComponent<AudioSource>().volume = 0;
    }

    public void ExitLost() //not used right now
    {
        soundEffect.clip = soundFight;
        soundEffect.volume = 0;
        GetComponent<AudioSource>().volume = 0.7f;
    }
}
