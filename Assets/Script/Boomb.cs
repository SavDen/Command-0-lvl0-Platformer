using UnityEngine;
using UnityEngine.UI;
public class Boomb : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private float _distanceShow;
    [SerializeField] private float _distance;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private MeshRenderer meshRenderer;
    
    // Start is called before the first frame update
    private void Awake()
    {
        _gameOverPanel.SetActive(false);
        
    }

    private void Update()
    {
        _distance = Vector3.Distance(transform.position, _playerTransform.position);

        if (_distance > _distanceShow)
            meshRenderer.enabled = false;
        else
            meshRenderer.enabled = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Move _playerMoved))
        {
           _playerMoved._activeInput = false;
           _scoreText.text = "0";
           _gameOverPanel.SetActive(true);
            
            
       }
        
    }
}