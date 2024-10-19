using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    Renderer myRend;
    Collider myTrig;
    
    InventoryManager invMgr;

    // Start is called before the first frame update
    public virtual void Start()
    {
        myRend = GetComponent<Renderer>();
        myTrig = GetComponent<Collider>();

        invMgr = GameObject.Find("Inventory").GetComponent<InventoryManager>();
    }

    public virtual void hide() {
        myRend.enabled = false;
        myTrig.enabled = false;
    }

    public virtual void pickUp() {
        hide();
        invMgr.buildIcon(gameObject);
    }

    public virtual void invClick(GameObject invIconGO) {
        print(name +  " clicked on in inventory!");
        Destroy(invIconGO);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;
        
        if(otherGO.tag == "Explo") {
            pickUp();
        }
    }    

}
