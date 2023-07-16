using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollectorNext5 : MonoBehaviour
{
    private int diamondCount;
    
    [SerializeField] TMP_Text elmaslarText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond5"));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Diamond5"))
        {
            collectionSoundEffect.Play();
            Destroy(other.gameObject);
            diamondCount++;
            elmaslarText.text = " " + (diamondCount + PlayerPrefs.GetInt("NextLevelDiamond5"));
            int NextLevelDiamond = PlayerPrefs.GetInt("NextLevelDiamond5") + diamondCount;
            PlayerPrefs.SetInt("NextLevelDiamond6", NextLevelDiamond);
        }
    }
}
