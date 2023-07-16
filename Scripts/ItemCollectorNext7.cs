using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollectorNext7 : MonoBehaviour
{
    private int diamondCount;
    
    [SerializeField] TMP_Text elmaslarText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond7"));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Diamond7"))
        {
            collectionSoundEffect.Play();
            Destroy(other.gameObject);
            diamondCount++;
            elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond7"));
            int NextLevelDiamond = PlayerPrefs.GetInt("NextLevelDiamond7") + diamondCount;
            PlayerPrefs.SetInt("NextLevelDiamond8", NextLevelDiamond);
        }
    }
}
