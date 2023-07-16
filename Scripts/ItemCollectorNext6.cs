using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollectorNext6 : MonoBehaviour
{
    private int diamondCount;
    
    [SerializeField] TMP_Text elmaslarText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond6"));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Diamond6"))
        {
            collectionSoundEffect.Play();
            Destroy(other.gameObject);
            diamondCount++;
            elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond6"));
            int NextLevelDiamond = PlayerPrefs.GetInt("NextLevelDiamond6") + diamondCount;
            PlayerPrefs.SetInt("NextLevelDiamond7", NextLevelDiamond);
        }
    }
}
