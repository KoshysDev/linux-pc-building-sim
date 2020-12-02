using UnityEngine;

public class SetComponent : MonoBehaviour
{
    private static string[] component = { "CPU", "RAM" };

    public int componentNum;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && component[componentNum] == GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject.tag)
        {
            GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject.transform.position = transform.position;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>().selectedObject.transform.rotation = transform.rotation;
        }
    }
}
