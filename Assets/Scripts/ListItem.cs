using UnityEngine;
using UnityEngine.UI;

public class ListItem : MonoBehaviour
{
    [SerializeField] Text labelText;

    public string Label
    {
        get
        {
            return labelText.text;
        }
        set
        {
            labelText.text = value;
        }
    }

}
