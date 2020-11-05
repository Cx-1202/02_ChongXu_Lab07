using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{
    public GameObject upcube;
    public GameObject downcube;
    public GameObject leftcube;
    public GameObject rightcube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spacebar();
        //upcube
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            upcube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if ( Input.GetKeyUp(KeyCode.UpArrow))
        {
            upcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //downcubee
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            downcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            downcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //left cube
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftcube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 1);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            leftcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //rightcube
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightcube.GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rightcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

    }

    private void spacebar()
    {
        //upcube
        if (Input.GetKeyDown(KeyCode.W))
        {
            upcube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            upcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //downcubee
        if (Input.GetKeyDown(KeyCode.S))
        {
            downcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            downcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //left cube
        if (Input.GetKeyDown(KeyCode.A))
        {
            leftcube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 1);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            leftcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //rightcube
        if (Input.GetKeyDown(KeyCode.D))
        {
            rightcube.GetComponent<MeshRenderer>().material.color = new Color(1, 0, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rightcube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
