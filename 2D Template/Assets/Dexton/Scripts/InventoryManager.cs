using UnityEngine;

/*public class InventoryManager : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    public

    public void AddItem(Item item)
    {
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            InventorySlot slot = inventorySlots[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot != null)
            {
                spawnNewItem(item, slot);
                return;
            }
        }
    }

    void spawnNewItem(Item item, InventorySlot slot)
    {
        GameObject gameObjectGo = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemGo.GetComponent<InventoryItem>();
        inventoryItem.initialiseItem(item);
    }
}*/
