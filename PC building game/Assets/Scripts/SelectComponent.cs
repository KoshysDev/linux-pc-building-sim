using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectComponent : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Outline>().OutlineWidth = 7;

            if (GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject != null)
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject.GetComponent<Outline>().OutlineWidth = 0;
                GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject = gameObject;
            }
            else
            {
                GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject = gameObject;
            }
            
        }
    }
}
