using UnityEngine;

public class GeneratorController : MonoBehaviour
{
    public float Speed
    {
        get
        {
            return _speed;
        }
        set
        {
            if (value <= 0)
            {
                _speed = 1;
            }
            else
            {
                _speed = value;
            }
        }
    }

    public float Distance
    {
        get
        {
            return _distance;
        }
        set
        {
            if (value <= 0)
            {
                _distance = 1;
            }
            else
            {
                _distance = value;
            }
        }
    }

    public float RespawnTime
    {
        get
        {
            return _time;
        }
        set
        {
            if (value <= 0)
            {
                _time = 1;
            }
            else
            {
                _time = value;
            }
        }
    }

    [SerializeField]
    private float _time;

    private float _timer;

    [SerializeField]
    public GameObject _cube;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _distance;

    private void Start()
    {
        SpawnCube();
    }

    private void Update()
    {
        _timer += Time.deltaTime;
        int seconds = (int)_timer % 60;
        if (_timer >= _time)
        {
            _timer = 0;
            SpawnCube();
        }
    }

    private void SpawnCube()
    {
        var cube = Instantiate(_cube).GetComponent<CubeController>();
        cube.Distance = _distance;
        cube.Speed = _speed;
    }
}