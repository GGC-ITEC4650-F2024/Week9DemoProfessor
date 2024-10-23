using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIController : MonoBehaviour
{
    RectTransform myRect;

    CrossHairController crossHair;
    InventoryManager invMgr;


    public bool menusInUse;

    // Start is called before the first frame update
    void Start()
    {
        myRect = GetComponent<RectTransform>();   

        crossHair = GameObject.Find("CrossHair").GetComponent<CrossHairController>();
        invMgr = GameObject.Find("Inventory").GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        menusInUse = (
            (Input.mousePosition.y / Screen.height) > myRect.anchorMin.y || 
            invMgr.isInUse()
        );

        Cursor.visible = menusInUse;
        crossHair.enabled = !menusInUse;
    }
}
