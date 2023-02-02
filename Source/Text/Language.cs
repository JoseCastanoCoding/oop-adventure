using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_adventure;
    public abstract class Language // Base class to store all the text in our game
    {
        public string Welcome { get; protected set; } = "";
        public string ChooseYourName { get; protected set; } = "";
        public string DefaultName { get; protected set; } = "";
        public string DefaultRoomName { get; protected set; } = "";
        public string DefaultRoomDescription { get; protected set; } = "";
    }
