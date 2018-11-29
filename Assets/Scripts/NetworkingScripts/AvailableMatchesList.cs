using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;

namespace Assets.Scripts.NetworkingScripts
{
    public static class AvailableMatchesList
    {
        public static event Action<List<MatchInfoSnapshot>> OnAvailableMatchesChanged = delegate { };

        public static List<MatchInfoSnapshot> matches = new List<MatchInfoSnapshot>();

        public static void HandleNewMatchList(List<MatchInfoSnapshot> matchList)
        {
            matches = matchList;
            OnAvailableMatchesChanged(matches);
        }
    }
}
