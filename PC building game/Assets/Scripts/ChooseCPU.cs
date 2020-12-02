using UnityEngine;

public class ChooseCPU : MonoBehaviour
{
    private GameObject _scrollView;

    private UiActive _uiActive; 

    private void Awake()
    {
        _scrollView = GameObject.FindGameObjectWithTag("V_Cpu");

        _uiActive = GameObject.FindGameObjectWithTag("GameController").GetComponent<UiActive>();
    }

    private void OnMouseOver()
    {
        ShowUi();
    }

    private void ShowUi()
    {
        if (Input.GetMouseButtonDown(0) && _uiActive.isCpuActive == false)
        {
            _scrollView.transform.position = new Vector3(_scrollView.transform.position.x, 110, _scrollView.transform.position.z);

            _uiActive.isCpuActive = true;
        }
        else if (Input.GetMouseButtonDown(0) && _uiActive.isCpuActive == true)
        {
            _scrollView.transform.position = new Vector3(_scrollView.transform.position.x, -200, _scrollView.transform.position.z);

            _uiActive.isCpuActive = false;
        }
    }
}
