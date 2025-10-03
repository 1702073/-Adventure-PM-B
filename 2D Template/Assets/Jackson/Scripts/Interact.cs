using UnityEngine;
using UnityEngine.InputSystem;

public class Interactions : MonoBehaviour
{
   public void InteractWith(InputAction.CallbackContext ctx)
   {
       if (ctx.ReadValue<float>() == 0) 
           return;


       RaycastHit2D hit = Physics2D.BoxCast(transform.position, new Vector2(1.5f, 1.5f), 0, Vector2.zero, 1, LayerMask.NameToLayer("Interactable"));
      
       if (hit)
       {
        Debug.Log(hit.collider.gameObject.name);
       }

   }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector2(1.5f, 1.5f)); 
    }
}
