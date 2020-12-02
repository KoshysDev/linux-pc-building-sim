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

            var objectInform = GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>();

            if (objectInform.selectedObject != null)
            {
                objectInform.selectedObject.GetComponent<Outline>().OutlineWidth = 0;
                objectInform.selectedObject = gameObject;
            }
            else
            {
                objectInform.selectedObject = gameObject;
            }
            
        }
    }
}
