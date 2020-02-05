using UnityEngine;

public class ButtonClicked : MonoBehaviour
{
	public void ButtonWasClicked()
	{
		Debug.Log("The button was clicked.");
	}

	public void ButtonWasClickedWithParameter(string parameter)
	{
		string message = string.Format("The button was clicked: {0}", parameter);
		Debug.Log(message);
	}

	void PrivateButtonWasClicked()
	{
		Debug.Log("This won't run as the direct result of a button click!");
	}

}
