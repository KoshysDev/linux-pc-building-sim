using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseRam : MonoBehaviour
{
    private GameObject _scrollView;

    private UiActive _uiActive;

    private void Awake()
    {
        _scrollView = GameObject.FindGameObjectWithTag("V_Ram");

        _uiActive = GameObject.FindGameObjectWithTag("GameController").GetComponent<UiActive>();
    }

    private void OnMouseOver()
    {
        ShowUi();
    }

    private void ShowUi()
    {
        if (Input.GetMouseButtonDown(0) && _uiActive.isRamActive == false)
        {
            _scrollView.transform.position = new Vector3(_scrollView.transform.position.x, 110, _scrollView.transform.position.z);

            _uiActive.isRamActive = true;
        }
        else if (Input.GetMouseButtonDown(0) && _uiActive.isRamActive == true)
        {
            _scrollView.transform.position = new Vector3(_scrollView.transform.position.x, -200, _scrollView.transform.position.z);

            _uiActive.isRamActive = false;
        }
    }
}
