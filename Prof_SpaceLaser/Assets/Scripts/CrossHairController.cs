using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHairController : MonoBehaviour
{
    public GameObject exploPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if(Physics.Raycast(r, out hitInfo)){
            GameObject g = hitInfo.collider.gameObject;
            transform.position = hitInfo.point + 0.1f * Vector3.up;

            if(Input.GetButtonDown("Fire1")) {
                GameObject ex = Instantiate(exploPrefab, 
                    transform.position, Quaternion.identity);
            }
        }
    }
}
