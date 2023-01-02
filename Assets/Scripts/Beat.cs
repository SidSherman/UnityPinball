
using UnityEngine;
using UnityEngine.InputSystem;
public class Beat : MonoBehaviour
{

    [SerializeField] private float _pushSpringTarget;
    [SerializeField] private float _pullSpringTarget;
    [SerializeField] private float _springValue;
    [SerializeField] private float _damperValue;
    [SerializeField] private HingeJoint _hingeJoint;
    private JointSpring _spring;
    private bool _isPush;

    private void Start()
    {
        PullBeater();
    }

    public void BeaterAction(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            PushBeater();
        }

        else if (context.phase == InputActionPhase.Canceled)
        {
            PullBeater();
        }
    }
    public void PushBeater()
    {
        
            Debug.Log("PushBeater");
            _spring.targetPosition = _pushSpringTarget;
            _spring.spring = _springValue;
            _spring.damper = _damperValue;
            _hingeJoint.spring = _spring;
    }
 
    
    public void PullBeater()
    {
       
            Debug.Log("PullBeater");
            _spring.targetPosition = _pullSpringTarget;
            _spring.spring = _springValue;
            _spring.damper = _damperValue;
            _hingeJoint.spring = _spring;
        
    }
}