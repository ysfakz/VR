using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Shovel : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    [SerializeField] private AudioClip audioClip;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        AudioSource.PlayClipAtPoint(audioClip, gameObject.transform.position, 1);
        GameManager.Instance.hasShovel = true;
        GameManager.Instance.shovelImage.SetActive(true);
        gameObject.SetActive(false);
        Debug.Log("Shovel Grabbed");
    }
}
