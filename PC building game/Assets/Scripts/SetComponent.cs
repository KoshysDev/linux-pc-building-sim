using UnityEngine;

public class SetComponent : MonoBehaviour
{
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject.transform.position = transform.position;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject.transform.rotation = transform.rotation;
        }
    }
}
