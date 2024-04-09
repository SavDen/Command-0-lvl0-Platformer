using UnityEngine;
using UnityEngine.UI;
public class Boomb : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _actUI;
    [SerializeField] private GameObject _numpad;

    [SerializeField] private Text _scoreText;
    [SerializeField] private Transform _player;
    [SerializeField] private MeshRenderer _meshRenderer;

    [SerializeField] private Move _playerMove;
    [SerializeField] private DactivationBomb _dactivationBomb;

    [SerializeField] private float _distance;
    [SerializeField] private float _distanceShow;
    [SerializeField] private int _bonus;
    // Start is called before the first frame update
    private void Awake()
    {
        _gameOverPanel.SetActive(false);
        
    }

    private void Update()
    {
        _distance = Vector3.Distance(transform.position, _player.position);

        if (_distance > _distanceShow)
        {
            _meshRenderer.enabled = false;
        }
        else
        {
            _actUI.SetActive(true);

            if(Input.GetKey(KeyCode.E))
            {
                _dactivationBomb.enabled = true;
                _playerMove.activeInput = false;
                _numpad.SetActive(true);
            }

            _meshRenderer.enabled = true;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Move player))
        {
            Dead();
        }
    }

    public void Dead()
    {
        _scoreText.text = "0";
        _playerMove.activeInput = false;
        _actUI.SetActive(false);
        _gameOverPanel.SetActive(true);
    }

    public void DactivationBoomb()
    {
        _scoreText.text = Bonus();
        _playerMove.activeInput = true;
        _actUI.SetActive(false);
        _numpad.SetActive(false);
        gameObject.SetActive(false);
    }

    string Bonus()
    {
        int score = int.Parse(_scoreText.text);
        _bonus = score + _bonus;
        return _bonus.ToString();

    }



}
