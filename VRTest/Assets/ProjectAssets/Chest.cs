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

            Vector3 chestBack = transform.position - transform.forward * 0; // 0.5m behind chest
            Vector3 uiPos = new Vector3(chestBack.x, transform.position.y + 1.5f, chestBack.z); // lifted a bit
            storyUI.transform.position = uiPos;
            storyUI.transform.rotation = transform.rotation * Quaternion.Euler(0, 90, 0);

            storyUI.SetActive(true);
            audioSource.PlayOneShot(audioClip);
            Debug.Log("Chest opened, UI shown");
        }
    }
}
