using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollectorNext3 : MonoBehaviour
{
    private int diamondCount;
    
    [SerializeField] TMP_Text elmaslarText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond3"));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Diamond3"))
        {
            collectionSoundEffect.Play();
            Destroy(other.gameObject);
            diamondCount++;
            elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond3"));
            int NextLevelDiamond = PlayerPrefs.GetInt("NextLevelDiamond3") + diamondCount;
            PlayerPrefs.SetInt("NextLevelDiamond4", NextLevelDiamond);
        }
    }
}
