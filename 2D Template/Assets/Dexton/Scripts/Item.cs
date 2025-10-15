using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;


[CreateAssetMenu(menuName = "ScriptableObjects/Item")]
public class Item : ScriptableObject
{
    [Header("Only Gamplay")]
    public TileBase Tile;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(5, 4);


    [Header("Only UI")]
    public bool stackable = true;

    [Header("Both")]
    public Sprite image;
}

public enum ItemType
{
    None,
    Weapon,
    Tool,
    Consumable,
    Miscellaneous
}

public enum ActionType
{
    None,
    Place,
    Remove,
    Use
}
