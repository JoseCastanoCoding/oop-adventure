using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure;

public abstract class Action
{
    public virtual string Name => ""; // when extended, name can be overridden by other classes that inherit from Action
    public virtual void Execute(string[] args)
    {
        throw new Exception("Nothing to execute");
    }
}


