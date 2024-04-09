
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
    

    [SerializeField] private Transform _player;
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private GameObject _actUI;

    // Start is called before the first frame update
   

    private void Update()
    {

        _distance = Vector3.Distance(transform.position, _playerTransform.position);

        _distance = Vector3.Distance(transform.position, _player.position);


        if (_distance > _distanceShow)
        {
            _meshRenderer.enabled = false;
            //_actUI.SetActive(false);
        }
        else
        {
            _meshRenderer.enabled = true;
            //_actUI.SetActive(true);

            if (Input.GetKey(KeyCode.Q))
            {

                Debug.Log("loot");
                _scoreText.text = Score();
                _actUI.SetActive(false);
                gameObject.SetActive(false);
                //можно выделить в отдельный метод

            }
        }
    }

    //По сути не нужен, можно удалить. Так же нет необходимости использовать Rigidbody 
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Move player))
        {

            Debug.Log(player + "loot");
            _scoreText.text = Score();
            gameObject.SetActive(false);
            //destroy();

            Debug.Log("onTrigger");
            _actUI.SetActive(true);

            if (Input.GetKey(KeyCode.Q))
            {

                Debug.Log(player + "loot");
                _scoreText.text = Score();
                _actUI.SetActive(false);
                gameObject.SetActive(false);

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out Move player))
        {
            _actUI.SetActive(false);
        }
    }

    string Score()
    {
        int score = int.Parse(_scoreText.text);
        _score = score + 1;
        return _score.ToString();

    }
}
