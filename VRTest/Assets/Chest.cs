using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Chest : MonoBehaviour
{
    public GameObject storyUI; // assign in Inspector

    private XRSimpleInteractable interactable;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
    }

    public void OnSelect(SelectEnterEventArgs args)
    {
        if (storyUI != null)
        {
            storyUI.SetActive(true);
            Debug.Log("Chest opened, UI shown");
        }
    }
}
