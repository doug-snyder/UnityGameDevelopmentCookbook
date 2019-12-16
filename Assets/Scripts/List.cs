using UnityEngine;

public class List : MonoBehaviour
{
    [SerializeField] int itemCount = 5;
    [SerializeField] ListItem itemPrefab;
    [SerializeField] RectTransform itemContainer;

    void Start()
    {
        for (int i = 0; i < itemCount; i++)
        {
            var label = string.Format("Item {0}", i);
            CreateNewListItem(label);
        }
    }

    public void CreateNewListItem(string label)
    {
        var newItem = Instantiate(itemPrefab);

        // Place it in container. Don't keep current position or scale.
        // UI system will lay it all out for us.
        newItem.transform.SetParent(
            itemContainer,
            worldPositionStays: false);

        newItem.Label = label;
    }

}
