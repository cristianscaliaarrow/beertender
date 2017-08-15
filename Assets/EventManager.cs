using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void fnc();
public class EventManager {

    public static Dictionary<EventId, fnc> par = new Dictionary<EventId, fnc>();

    public static void AddEvent(EventId id, fnc function) {
        if (par.ContainsKey(id))
        {
            par[id] = function;
        }else
        {
            par.Add(id, function);
        }
    }

    public static void DispatchEvent(EventId id)
    {
        if (par.ContainsKey(id))
        {
            par[id]();
        }
    }

	
}

public enum EventId
{
    UpdatePendingMessages
}
