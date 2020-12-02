using UnityEngine;

public class AddComponent : MonoBehaviour
{
    public void CpuUiClick(GameObject cpu)
    {
        cpu.SetActive(true);

        ComponentClear("V_Cpu");

        GameObject.FindGameObjectWithTag("GameController").GetComponent<UiActive>().isCpuActive = false;
    }

    public void RamUiClick(GameObject cpu)
    {
        cpu.SetActive(true);

        ComponentClear("V_Ram");

        GameObject.FindGameObjectWithTag("GameController").GetComponent<UiActive>().isRamActive = false;
    }

    private void ComponentClear(string uiTag)
    {
        var _scrollView = GameObject.FindGameObjectWithTag(uiTag);

        _scrollView.transform.position = new Vector3(_scrollView.transform.position.x, -200, _scrollView.transform.position.z);
    }
}
