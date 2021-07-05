using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VIDE_Data;

public class PlayerInteract : MonoBehaviour
{

    RaycastHit hit;
    public Camera camera;
    public float rayDistance;
    public Button buttontalker;
    public static GameObject talker;
    
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
                
               buttontalker.gameObject.SetActive(true);

                
                talker = hit.transform.gameObject;

                if(Instructions.state==2)
                    FindObjectOfType<Instructions>().SetInstruction(3);
                //print("hit");
            }
            else 
            {
                buttontalker.gameObject.SetActive(false);

                if (GameObject.Find("VideContainer"))
                {
                    FindObjectOfType<VideController>().TalkerEnd();
                    //print("Ends");
                }
            }            
        }
        else
        {
            buttontalker.gameObject.SetActive(false);

            if (GameObject.Find("VideContainer"))
            {
                FindObjectOfType<VideController>().TalkerEnd();
                print("Ends");
            }
        }
    }

    
}

