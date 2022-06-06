using UnityEngine;

[AddComponentMenu("Hammer SandBox Tools SDK/Interact/Door/Gate")]
public class Gate : MonoBehaviour
{
    public float Up;
    public float GateSpeed;

    public bool Openning;

    private Vector3 openPos;
    private Vector3 closePos;

    public AudioClip openClip;
    public AudioClip closeClip;

    public void OpenGate(float t)
    {

    }
    public void CloseGate()
    {

    }
}
