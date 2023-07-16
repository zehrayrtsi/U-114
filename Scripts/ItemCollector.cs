using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ItemCollector : MonoBehaviour
{
    private int diamondCount;

    [SerializeField] TMP_Text elmaslarText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Start()
    {
        elmaslarText.text = " " + diamondCount;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Diamond"))
        {
            collectionSoundEffect.Play();
            Destroy(other.gameObject);
            diamondCount++;
            elmaslarText.text = " " + diamondCount;
            PlayerPrefs.SetInt("NextLevelDiamond2", diamondCount);
        }
    }
}
