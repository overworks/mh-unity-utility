using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mh
{
    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance
        {
            get
            {
                if (shuttingDown)
                {
                    Debug.LogWarning($"{nameof(T)} instance will not be returned because the application is shutting down");
                    return null;
                }

                if (instance.IsRealNull())
                {
                    var instances = FindObjectsOfType<T>();

                    if (instances.Length > 0)
                    {
                        instance = instances[0];
                    }

                    if (instances.Length > 1)
                    {
                        Debug.LogError($"There are more than one {typeof(T).Name} in the scene.");
                    }

                    if (instance.IsRealNull())
                    {
                        var goName = typeof(T).Name;
                        var go = GameObject.Find(goName);
                        if (!go)
                        {
                            go = new GameObject(goName);
                        }

                        instance = go.AddComponent<T>();
                    }
                }
                return instance;
            }
        }

        private static T instance;
        private static bool shuttingDown;

        protected virtual void OnAwake() { }
        protected virtual void OnClose() { }
        protected virtual void OnShutDown() { }
        

        private void Awake()
        {
            if (instance && instance != this)
            {
                Destroy(gameObject);
                return;
            }

            OnAwake();
        }

        private void OnDestroy()
        {
            if (this == instance)
            {
                instance = null;
            }

            OnClose();
        }

        private void OnApplicationQuit()
        {
            shuttingDown = true;

            OnShutDown();
        }
    }
}