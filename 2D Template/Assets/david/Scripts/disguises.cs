using UnityEngine;

public class disguises : MonoBehaviour
{


    private bool isDisguised = false;
    public GameObject disguise; // Layer for disguises
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && !isDisguised)
        {
            disguise.SetActive(true);
            isDisguised = true;
            Debug.Log("Tab key was pressed.");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Tab) && isDisguised)
            {
                disguise.SetActive(false);
                isDisguised = false;
                Debug.Log("Tab key was pressed.");
            }
        }
        
      



    }
}
