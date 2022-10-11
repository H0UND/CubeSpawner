using UnityEngine;

public class CubeController : MonoBehaviour
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

    private Vector3 Position
    {
        get
        {
            return gameObject.transform.localPosition;
        }
        set
        {
            gameObject.transform.localPosition = value;
        }
    }

    private float _speed;

    private float _distance;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Position = new Vector3(Position.x, 0.5f, Position.z + _speed * Time.deltaTime);
        if (Position.z >= _distance)
        {
            Destroy(gameObject);
        }
    }
}