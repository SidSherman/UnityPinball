
using UnityEngine;
using UnityEngine.InputSystem;

public class PinballSpring : MonoBehaviour
{
    [SerializeField] private float _pullAnchor;
    [SerializeField] private float _pushAnchor;
    [SerializeField] private SpringJoint _springJoint;
    // Start is called before the first frame update
    void Start()
    {
        Push();
    }
    
    public void SpringAction(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            Pull();
        }

        else if (context.phase == InputActionPhase.Canceled)
        {
            
            Push();
        }
    }
    
    public void Push()
    {
        if (_springJoint)
        {
            _springJoint.anchor = new Vector3(0,_pushAnchor,0);
        }
    }
    
    public void Pull()
    {
        if (_springJoint)
        {
            _springJoint.anchor = new Vector3(0,_pullAnchor,0);
        }
    }

}
