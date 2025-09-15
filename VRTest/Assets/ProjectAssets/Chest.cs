using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Chest : MonoBehaviour
{
    public GameObject storyUI;
    private XRSimpleInteractable interactable;
    private AudioSource audioSource;
    [SerializeField] private AudioClip audioClip;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
        audioSource = GetComponent<AudioSource>();
    }

    public void OnSelect(SelectEnterEventArgs args)
    {
        if (storyUI != null)
        {
            storyUI.SetActive(true);
            audioSource.PlayOneShot(audioClip);
            Debug.Log("Chest opened, UI shown");
        }
    }
}
