﻿using UnityEngine;
using UnityEngine.UI;

public class ResumeGameScript : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void onMouseDown() {
        Debug.Log("clicked");
        Destroy(transform.parent.gameObject);
        GameController.Instance.player.SetActive(true);
    }

    void OnEnable()
    {
        //Register Slider Events
        button.onClick.AddListener(delegate { onMouseDown(); });
    }

    void OnDisable()
    {
        //Un-Register Slider Events
        button.onClick.RemoveAllListeners();
    }
}
