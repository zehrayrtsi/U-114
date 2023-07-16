using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollectorNext : MonoBehaviour
{
    private int diamondCount;
    
    [SerializeField] TMP_Text elmaslarText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond2"));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Diamond2"))
        {
            collectionSoundEffect.Play();
            Destroy(other.gameObject);
            diamondCount++;
            elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond2"));
            int NextLevelDiamond = PlayerPrefs.GetInt("NextLevelDiamond2") + diamondCount;
            PlayerPrefs.SetInt("NextLevelDiamond3", NextLevelDiamond);
        }
    }
}
