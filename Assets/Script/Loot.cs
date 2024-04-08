
using UnityEngine;
using UnityEngine.UI;

public class Loot : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private int _score;
    [SerializeField] private float _distanceShow;
    [SerializeField] private float _distance;
    [SerializeField] GameObject _player;
    [SerializeField] MeshRenderer meshRenderer;
    // Start is called before the first frame update
   

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
            Debug.Log(player + "loot");
            _scoreText.text = Score();
            gameObject.SetActive(false);
        }

    }

    string Score()
    {
        int score = int.Parse(_scoreText.text);
        _score = score + 1;
        return _score.ToString();

    }
}
