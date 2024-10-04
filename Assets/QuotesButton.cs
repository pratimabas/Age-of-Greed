using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.EventSystems;

public class QuotesButton : MonoBehaviour, IPointerClickHandler
{

    public TMP_Text textToToggle; // Reference to the Text component you want to toggle

    void Start()
    {
        textToToggle.gameObject.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        textToToggle.gameObject.SetActive(true);
    }
}
