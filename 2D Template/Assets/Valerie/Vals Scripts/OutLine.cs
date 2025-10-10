using UnityEngine;

public class OutLine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseEnter()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
       transform.GetChild(0).gameObject.SetActive(false);
    }
}
