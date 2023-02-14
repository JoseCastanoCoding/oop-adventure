using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure;

public sealed class Actions // this tells the compiler that this class is going to be unmodifiable
{
    private static Actions _instance; // static property that represents a single instance of the actions class
    public static Actions Instance 
    {
        get
        {
            if (_instance == null)
                _instance = new Actions();
            return _instance;
        }
    }
    private readonly Dictionary<string, Action> _registeredActions = new(); // private constructor, gonna ensure that there is no way to create an instance of the actions class outside of the instance instantiator
    private Actions()
    {

    }
    public void Register(Action action)
    {
        var name = action.Name.ToLower();

        if(_registeredActions.ContainsKey(name))
            _registeredActions[name] = action;
        else
            _registeredActions.Add(name, action);
    }
    public void Execute(string[] args)
    {
        var actionName = args[0];

        if (_registeredActions.ContainsKey(actionName))
            _registeredActions[actionName].Execute(args);
        else
            Console.WriteLine(Text.Language.ActionError);
    }
}

