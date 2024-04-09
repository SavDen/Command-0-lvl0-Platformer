
using UnityEngine;
using UnityEngine.UI;

public class Loot : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private int _score;
    [SerializeField] private float _distanceShow;
    [SerializeField] private float _distance;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private MeshRenderer meshRenderer;
    
    // Start is called before the first frame update
   

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
        if(other.TryGetComponent(out Move player))
        {
            Debug.Log(player + "loot");
            _scoreText.text = Score();
            gameObject.SetActive(false);
            //destroy();
        }
    }

    string Score()
    {
        int score = int.Parse(_scoreText.text);
        _score = score + 1;
        return _score.ToString();

    }
}
