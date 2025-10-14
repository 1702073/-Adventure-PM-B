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
        if (Input.GetKeyDown(KeyCode.G) && !isDisguised)
        {
            disguise.SetActive(true);
            isDisguised = true;
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.G) && isDisguised)
            {
                disguise.SetActive(false);
                isDisguised = false;

            }
        }
        
      



    }
}
