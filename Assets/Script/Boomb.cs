using UnityEngine;
using UnityEngine.UI;
public class Boomb : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private float _distanceShow;
    [SerializeField] private float _distance;
    [SerializeField] GameObject _player;
    [SerializeField] MeshRenderer meshRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        _gameOverPanel.SetActive(false);
        
    }

    private void Update()
    {
        _distance = Vector3.Distance(gameObject.transform.position, _player.transform.position);

        if (_distance > _distanceShow)
            meshRenderer.enabled = false;
        else
            meshRenderer.enabled = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Move player))
        {
            player.activeInput = false;
            _scoreText.text = "0";
            _gameOverPanel.SetActive(true);
        }
    }
}
