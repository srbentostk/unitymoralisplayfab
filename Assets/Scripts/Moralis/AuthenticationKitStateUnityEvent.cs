using System;
using UnityEngine.Events;

namespace Assets.Scripts.Moralis
{
    /// <summary>
    /// See <see cref="AuthenticationKit"/> comments for a feature overview.
    ///
    /// The main event for <see cref="AuthenticationKit"/>.
    /// 
    /// </summary>
    [Serializable]
    public class AuthenticationKitStateUnityEvent : UnityEvent<AuthenticationKitState>
    {
    }
}
