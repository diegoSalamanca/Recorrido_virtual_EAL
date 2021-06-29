using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{

    RaycastHit hit;
    public Camera camera;
    public float rayDistance;
    public Button buttontalker;
    // Start is called before the first frame update
    void Start()
    {
        buttontalker.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        //Debug.DrawRay(transform.position, transform.forward, Color.red);

        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, 5))
        {
            if (hit.transform.CompareTag("talker"))
            {
                buttontalker.interactable = true;
                print("hit");
            }
            else 
            {
                buttontalker.interactable = false;
            }            
        }
        else
        {
            buttontalker.interactable = false;
        }
    }
}

