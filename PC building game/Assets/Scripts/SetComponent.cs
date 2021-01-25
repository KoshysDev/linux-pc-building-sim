using UnityEngine;

public class SetComponent : MonoBehaviour
{
    private static string[] component = { "CPU", "RAM", "M2_SSD" };

    public int componentNum;
    public bool isFree = true;

    private void OnMouseOver()
    {
        var objectInform = GameObject.FindGameObjectWithTag("GameController").GetComponent<SelectedObjectInformation>();

        if (Input.GetMouseButtonDown(0) && isFree && component[componentNum] == objectInform.selectedObject.tag)
        {
            isFree = false;
            //pos
            objectInform.selectedObject.transform.position = transform.position;
            //rot
            objectInform.selectedObject.transform.rotation = transform.rotation;
        }
    }
}
