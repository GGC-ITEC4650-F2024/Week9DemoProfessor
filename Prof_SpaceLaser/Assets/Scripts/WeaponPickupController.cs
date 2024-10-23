using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickupController : PickUpController
{
    public override void invClick(GameObject invIconGO) {
        base.invClick(invIconGO);

        //make laser beam yellow
        CrossHairController cross = GameObject.Find("CrossHair")
            .GetComponent<CrossHairController>();

        ParticleSystem.MainModule psm = cross.laserPS.main;
        psm.startColor = Color.yellow;

    }

}
