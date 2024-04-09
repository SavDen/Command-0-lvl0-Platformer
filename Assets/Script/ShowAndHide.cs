using UnityEngine;

public class ShowAndHide : MonoBehaviour
{
    [SerializeField] private float _distanceShow;
    [SerializeField] private float _distance;
    [SerializeField] private Transform _player;
    private void Awake()
    {
        //_player = GameObject.Find("Robot");
        //if (_player.TryGetComponent(out Move distance))
        //    _distance = distance.distance;
    }

    // Update is called once per frame
    void Update()
    {
        _distance = Vector3.Distance(transform.position, _player.transform.position);

        if (_distance > _distanceShow)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }
}
