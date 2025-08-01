
using UnityEngine;

namespace Game.Pack
{
    /// <summary>
    /// 演示案例总控
    /// </summary>
    public class BookObject : MonoBehaviour
    {
        protected virtual void Awake()
        {
            Debug.LogWarning("book object awake !!!");
        }
        
        protected virtual void Start()
        {
            Debug.LogWarning("book object start !!!");
        }
    }
}
