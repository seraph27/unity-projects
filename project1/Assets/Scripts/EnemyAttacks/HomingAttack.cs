﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingAttack : MonoBehaviour
{
    public GameObject missilePrefab;
    GameObject player;
    float reloadDelay;
    public int missileRange = 6;
    // Start is called before the first frame update
    void Start()
    {
        player = GameController.Instance.player;
    }

    // Update is called once per frame
    void Update()
    {
        reloadDelay += Time.deltaTime;

        if(reloadDelay >= 1){
            if((player.transform.position - transform.position).magnitude < missileRange){ 
                GameObject missile = Instantiate(missilePrefab, transform.position, Quaternion.identity);
                missile.GetComponent<MissileController>().owner = gameObject;
                reloadDelay = 0;
            }
        }

    }
}
