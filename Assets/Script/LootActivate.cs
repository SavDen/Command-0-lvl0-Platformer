using UnityEngine;
using UnityEngine.Serialization;

public class LootActivate : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    private Collider _locatorColider;
    private void Start()
    {
        _renderer.enabled = false;
    }

    private void Update()
    {
        if (_locatorColider.enabled == false && _renderer.enabled == true)
        {
            _renderer.enabled = false;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        _locatorColider = other.GetComponent<Collider>();
        if (_locatorColider.enabled == true)
        {
            _renderer.enabled = true;
        }
    }
}
